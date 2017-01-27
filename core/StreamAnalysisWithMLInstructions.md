## Instructions

Your solution has been successfully deployed!

You used your Twitter Application OauthConsumerKey that starts with {Outputs.oauthConsumerKeySub}

You can see your dashboard [here]({Outputs.solutionDashboardUrl}).	
<iframe width="780" height="480" src="{Outputs.solutionDashboardUrl}" frameborder="0" allowfullscreen></iframe>

## Cortana Intelligence Services
1. Azure Stream Analytics - To start/stop your Stream Analytics Job, you may use the START / STOP commands [here]({Outputs.saJobOutputsUrl}).  Choose __Now__ for the Job output start time and click on __Start__. 
2. Azure Storage - Click [here]({Outputs.storageAccountUrl}) to view your Storage account on the Azure portal to get the Storage account name and access key
3. Azure SQL Database is used to save the data. You can use the following credentials to log in your database and check the results.
		
    * Server: {Outputs.sqlServerName}.database.windows.net
    * Database: {Outputs.sqlDatabaseName}
    * Username: {Outputs.sqlServerUsername}
    * Password: You can manage your SQL server password from [Azure portal]({Outputs.sqlServerUrl})

4. Azure Machine Learning - If you are interested in the Sentiment Analysis ML Web Service:
	* You can view your Stream Analysis with Azure ML machine learning web service API manual [here]({Outputs.webServiceHelpUrl}).
	* You can view the experiment by navigating to your [Machine Learning Workspace]({Outputs.experimentUrl}).

5. Power BI - You can download the Power BI Desktop pbix file [here]({PatternAssetBaseUrl}/dashboards/TryItNow/StreamingTweets2.pbix) to connect to your SQL Database.
   > **Note**: If you are downloading using an Edge Browser the .pbix file extension might change to .zip and you will need to modify the extension to .pbix to open the file in Power BI Desktop.
   * Open the Power BI Desktop report and choose Edit Queries > Data Source Settings > Change Source and then change the Server and Database and Click OK.
   * Close the Data Source Settings by clicking Close and then click Refresh which will prompt you for the username and password.

## Notes
Change the Database tables, Azure ML experiment, and Stream Analytics job query as appropriate.