using System.Collections.Generic;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace CloudGuides
{
    public class LambdaMethodHandler
    {
        APIGatewayProxyResponse HandleRequest(
            IDictionary<string, object> input,
            ILambdaContext context)
        {
            return new APIGatewayProxyResponse
            {
                Body = Newtonsoft.Json.JsonConvert.SerializeObject(input),
                StatusCode = 200,
                Headers = new Dictionary<string, string> {{"Access-Control-Allow-Origin", "*"}}
            };
        }
    }
}
