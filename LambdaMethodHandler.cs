using System.Collections.Generic;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace CloudGuides
{
    public class LambdaMethodHandler
    {
        ProxyResponse HandleRequest(
            IDictionary<string, object> input,
            ILambdaContext context)
        {
            return new ProxyResponse(
                "200", 
                Newtonsoft.Json.JsonConvert.SerializeObject(input));   
        }
    }
}
