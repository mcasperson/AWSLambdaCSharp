using System.Collections.Generic;
using Amazon.Lambda.Core;

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
