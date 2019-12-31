using System.Collections.Generic;

namespace CloudGuides
{
    public class ProxyResponse
    {
        public string Body { get; }
        public string StatusCode { get; }
        public IDictionary<string, string> Headers { get; }
        
        public ProxyResponse(string statusCode, string body, IDictionary<string, string> headers)
        {
            Body = body;
            StatusCode = statusCode;
            Headers = headers ?? new Dictionary<string, string>();
            AddCORSHeaders();
        }
        
        public ProxyResponse(string statusCode, string body)
        {
            Body = body;
            StatusCode = statusCode;
            Headers = new Dictionary<string, string>();
            AddCORSHeaders();
        }

        void AddCORSHeaders()
        {
            Headers["Access-Control-Allow-Origin"] = "*";
        }
    }
}