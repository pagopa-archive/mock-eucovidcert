using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System;

namespace DGC.Function
{
    public class Certificate
    {
        private const string AddedDelayConfigKey = "MockAPI:AddedDelay";
        private const string ForceStatusCodeFeature = "ForceStatusCode";
        private const string ForceStatusCodeKey = "MockAPI:ForceStatusCode";
        private const string FailureRateKey = "MockAPI:FailureRate";

        private readonly IConfiguration _configuration;
        private readonly IConfigurationRefresher _configurationRefresher;
        private readonly IFeatureManagerSnapshot _featureManagerSnapshot;

        public Certificate(IFeatureManagerSnapshot featureManagerSnapshot, IConfiguration configuration, IConfigurationRefresherProvider refresherProvider)
        {
            _configuration = configuration;
            _featureManagerSnapshot = featureManagerSnapshot;
            _configurationRefresher = refresherProvider.Refreshers.First();
        }


        [FunctionName("Certificate")]
        [OpenApiOperation(operationId: "getCertificate")]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiParameter(name: "auth_code", Required = true, Type = typeof(string), Description = "The **auth_code** parameter")]
        [OpenApiParameter(name: "fiscal_code", Required = true, Type = typeof(string), Description = "The **fiscal_code** parameter")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed Certificate/getCertificate/Run");

            // Signal to refresh the configuration if the registered key(s) is modified.
            // This will be a no-op if the cache expiration time window is not reached.
            // The configuration is refreshed asynchronously without blocking the execution of the current function.
            await _configurationRefresher.TryRefreshAsync();

            if (await _featureManagerSnapshot.IsEnabledAsync("Broken"))
            {
                var r = new Random(DateTime.Now.Second).Next(1,99);

                if (r <= Convert.ToInt32(_configuration[FailureRateKey]))
                {
                    throw new InvalidOperationException($"Broken feature flag is ON.");
                }
            }

            if (int.TryParse(_configuration[AddedDelayConfigKey], out int addedDelay) && addedDelay > 0)
            {
                log.LogInformation($"{AddedDelayConfigKey}: {addedDelay}");
                await Task.Delay(addedDelay);
            }

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            string auth_code = data?.auth_code;
            string fiscal_code = data?.fiscal_code;

            var responseMessage = $"From body: auth_code [{auth_code}], fiscal_code [{fiscal_code}] ";

            var response = new ObjectResult(responseMessage);
            if (await _featureManagerSnapshot.IsEnabledAsync(ForceStatusCodeFeature) && int.TryParse(_configuration[ForceStatusCodeKey], out int statusCode))
            {
                response.StatusCode = statusCode;
            }
            else
            {
                response.StatusCode = 200;
            }
            return response;
        }
    }
}
