#Solution How To Guide for ProjectHudson solution
* [Summary](#Summary)
* [Description](#Description)
* [Prerequisites](#Prerequisites)
* [Post Deployment Guidance](#PostDeployment)
  * [Scaling](#scaling)
  * [Customization](#customization)
  * [Enhancing Visualization](#visualization)
  * [Security](#security)

#<a name="Summary"></a>Summary
<Guide type="ShortDescription">
Deploying multiple ARM templates and functions to accomplish actions that cannot be accomplsihed through ARM templates to capture, curate, and consume tweets from the Twitter streaming API.
</Guide>

#<a name="Description"></a>Description
### Estimated Provisioning Time: <Guide type="EstimatedTime">10 Minutes</Guide>
<Guide type="LongDescription">
This tutorial demonstrates how to capture, curate, and consume tweets from the Twitter streaming API.  You enter keywords and your oauth tokens to capture tweets, calculate a sentiment score, and then consume the output in embedded Power BI.

[![Solution Diagram]({PatternAssetBaseUrl}/StreamAnalysisWithMLDiagram.JPG)](https://raw.githubusercontent.com/DataSnowman/projecthudson/master/assets/StreamAnalysisWithMLDiagram.JPG)

This solution sets up the infrastructure in the diagram above.

The pattern involves the following four steps:

1. Setting up an Azure Function to collect Twitter data based on user specified keywords.
2. Pumping ingested tweets into Azure Event Hub which can accept millions of events per second.
3. Processing incoming tweets with an Azure Stream Analytics job that stores the data in Azure Blob Storage and Azure SQL Database. In addition, the Stream Analytics job calls an Azure Machine Learning web service to determine the sentiment of each tweet. 
4. Visualizing real-time metrics about inferred sentiment using Embedded Power BI.
</Guide>

#<a name="Prerequisites">Prerequisites</a>
<Guide type="Prerequisites">
1. [Twitter account](https://twitter.com/login)
2. [Twitter application](https://apps.twitter.com)
3. Twitter's Streaming API OAuth credentials
  - On the Twitter application page, click on the *Keys and Access Tokens* tab
  - *Consumer Key (API Key)* and *Consumer Secret (API Secret)* can be found under **Application Settings** section
  - Under **Your Access Token** section, click on *Create my access token* to obtain both *Access Token* and *Access Token Secret*

More details on Twitter's Streaming API OAuth access token can be found [here](https://dev.twitter.com/oauth/overview/application-owner-access-tokens).

You can avoid showing this section in CIQS by removing the &lt;Prerequisites&gt; tag.
</Guide>

# <a name="PostDeployment"></a>Post Deployment Guidance
<Guide type="PostDeploymentGuidance" url="https://github.com/DataSnowman/projecthudson"/>
## <a name="scaling"></a>Scaling
* More descriptions about scaling.

## <a name="customization"></a>Customization
* More descriptions about customization.

## <a name="visualization"></a>Enhancing Visualization
* More descriptions about enhancing visualization.

## <a name="security"></a>Security
* More descriptions about security.