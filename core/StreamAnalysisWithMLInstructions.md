## Instructions

Your solution has been successfully deployed!

You used your Twitter Application OauthConsumerKey that starts with {Outputs.oauthConsumerKeySub}

You can see your dashboard [here]({Outputs.solutionDashboardUrl}).	
<iframe width="780" height="480" src="{Outputs.solutionDashboardUrl}" frameborder="0" allowfullscreen></iframe>

1. Go [here]({Outputs.saJobOutputsUrl}) and click on the __Outputs__ tile, then click on __PowerBIOutput__, and then click on __Renew authorization__ (Enter your Power BI userid and password) to set up authorization for the Stream Analytics Power BI Output.  Then click on __Save__ to test the connection.
2. To start/stop your Stream Analytics Job, you may use the START / STOP commands [here]({Outputs.saJobOutputsUrl}).  Choose __Now__ for the Job output start time and click on __Start__. 
3. Now go to [Power BI Dashboard](https://powerbi.microsoft.com/) and use a Real-time dataset to build reports and dashboards using your data!
4. If you don't have a Work or school account that provides access to the Power BI Portal download this Power BI Desktop pbix file [here]({PatternAssetBaseUrl}/dashboards/TryItNow/StreamingTweets2.pbix) to connect to your Storage account
   > **Note**: If you are downloading using an Edge Browser the .pbix file extension might change to .zip and you will need to modify the extension to .pbix to open the file in Power BI Desktop
5. Click [here]({Outputs.storageAccountUrl}) to view your Storage account on the Azure portal to get the Storage account name and access key
6. Azure SQL Database
	
    Azure SQL database is used to save the data and forecast results. You can use the following credentials to log in your database and check the results.
		
    * Server: {Outputs.sqlServerName}.database.windows.net
    * Database: {Outputs.sqlDatabaseName}
    * Username: {Outputs.sqlServerUsername}
    * Password: You can manage your SQL server password from [Azure portal]({Outputs.sqlServerUrl})
7. Open the Power BI Desktop report and choose Edit Queries > Data Source Settings > Change Source and then paste the Storage account name and Click OK
8. Close the Data Source Settings by clicking Close and then click Refresh which will prompt you for your Storage account key
9. Copy and paste your Storage account key and click Connect

## Notes
Change the Stream Analytics job query as appropriate

## Reference
1. If you are interested in the seeing the status of the Twitter client web job which pulls data from Twitter:
	* You can view the logs of the Web Job [here]({Outputs.webJob2LogsUrl}).
2. If you are interested in the Twitter client application source code:
	* [Download]({PatternAssetBaseUrl}/TwitterClientForAML.zip) Twitter client application and open it in Visual Studio
	* Don't have Visual Studio? Try our [Microsoft Data Science Virtual Machine](https://gallery.cortanaintelligence.com/Solution/Microsoft-Data-Science-Virtual-Machine-2) with additional details [here](https://azure.microsoft.com/en-us/documentation/articles/machine-learning-data-science-provision-vm/)
	* Directions on configuring the Twitter client application [here](https://azure.microsoft.com/en-us/documentation/articles/stream-analytics-twitter-sentiment-analysis-trends/)
3. If you are interested in the Sentiment Analysis ML Web Service:
	* You can view your Stream Analysis with Azure ML machine learning web service API manual [here]({Outputs.webServiceHelpUrl}).
	* You can view the experiment by navigating to your [Machine Learning Workspace]({Outputs.experimentUrl}).
	* You can view the logs of the Web Job that creates the ML service [here]({Outputs.webJobLogsUrl}).