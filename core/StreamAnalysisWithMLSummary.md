[![Solution Diagram]({PatternAssetBaseUrl}/StreamAnalysisWithMLDiagram.JPG)]({PatternAssetBaseUrl}/StreamAnalysisWithMLDiagram.JPG)

The path for [TryItNow](https://start.cortanaintelligence.com/tryitnow/dashboard/newstreamanalysiswithml).  Note the Tutorial needs to be deployed as an official CIQS Tutorial for the TryItNow link to work.

This solution sets up the infrastructure in the diagram above. The various steps are as follows:

* Setting up an Azure WebJob to collect Twitter data based on user specified keywords.
* Pumping ingested tweets into Azure Event Hub which can accept millions of events per second
* Processing incoming tweets with an Azure Stream Analytics job that stores the raw data in Azure Blob Storage. In addition, the Stream Analytics job calls an Azure Machine Learning web service to determine the sentiment of each tweet. 
* Visualizing real-time metrics about inferred sentiment using Power BI.

## Prerequisites
This solution sets up an [Azure Web Job](https://azure.microsoft.com/en-us/documentation/articles/websites-webjobs-resources/) called Twitter Client to collect tweets. 

To run the TwitterClient web job, you will need:

1. A [Twitter account](https://twitter.com/login)
2. A [Twitter application](https://apps.twitter.com)
3. Twitter's Streaming API OAuth credentials
  - On the Twitter application page, click on the *Keys and Access Tokens* tab
  - *Consumer Key (API Key)* and *Consumer Secret (API Secret)* can be found under **Application Settings** section
  - Under **Your Access Token** section, click on *Create my access token* to obtain both *Access Token* and *Access Token Secret*

More details on Twitter's Streaming API OAuth access token can be found [here](https://dev.twitter.com/oauth/overview/application-owner-access-tokens).