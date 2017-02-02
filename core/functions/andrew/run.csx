#r "System"
#r "System.Net"
#r "System.Runtime"
#r "System.Threading.Tasks"
#r "System.IO"
#r "Newtonsoft.Json"
#r "System.Configuration"

#load "..\CiqsHelpers\All.csx"

using Microsoft.Azure;
//using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;
//using Microsoft.Azure.Management.Resources.Models;

public static async Task Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"C# manually triggered function called with input: {req}");
    //var dict = await req.Content.ReadAsAsync<IDictionary<string, string>>();

    var parametersReader = await CiqsInputParametersReader.FromHttpRequestMessage(req);

    string ResourceGroupName = parametersReader.GetParameter<string>("resourceGroupName");
    string SaJobName = parametersReader.GetParameter<string>("saJobName"); 
    string SubscriptionId = parametersReader.GetParameter<string>("subscriptionId");
    var authorizationToken = parametersReader.GetParameter<string>("accessToken");
    await StartStreamJobs(SubscriptionId, authorizationToken, ResourceGroupName, SaJobName, log);  
}

public static async Task StartStreamJobs(string SubscriptionId, string authorizationToken, string ResourceGroupName, string saJobName, TraceWriter log)
        {
            log.Info("Asa job start");

            try
            {

                TokenCloudCredentials credentials = GetStreamAnalyticsCredentials(SubscriptionId, authorizationToken);
                StreamAnalyticsManagementClient streamClient = new StreamAnalyticsManagementClient(credentials);

               
                    log.Info($"Starting job {saJobName}");
                    await StartJob(streamClient, credentials, ResourceGroupName, saJobName, log);
            }
            catch (Exception ex)
            {
                log.Info($"Asa job start error : {ex.Message}");
                throw;
            }
            log.Info("Asa job start complete");

        }

  private static async Task StartJob(StreamAnalyticsManagementClient streamClient, TokenCloudCredentials credentials, String resourceGroup, String jobName, TraceWriter log)
        {

            JobStartParameters jobStartParameters = new JobStartParameters
            {
                OutputStartMode = OutputStartMode.JobStartTime
            };

            LongRunningOperationResponse response = streamClient.StreamingJobs.Start(resourceGroup, jobName, jobStartParameters);
            
            while (response.Status != OperationStatus.Succeeded)
            {
                var uri = new Uri(response.OperationStatusLink);
                
                response = await streamClient.GetLongRunningOperationStatusAsync(response.OperationStatusLink);

                if (response.Status == OperationStatus.Failed)
                {
                    throw new Exception(string.Format("Start SA job: {0} failed", jobName));
                }
                await Task.Delay(1000);
            }
        }

private static TokenCloudCredentials GetStreamAnalyticsCredentials(string SubscriptionId, string authorizationToken)
        {
            
            TokenCloudCredentials credentials = new TokenCloudCredentials(
                SubscriptionId,
                authorizationToken);

            return credentials;
        }