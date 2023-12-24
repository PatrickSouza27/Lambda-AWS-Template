using Amazon.Lambda;
using Amazon.Lambda.Model;
using Newtonsoft.Json;

namespace client
{
    class Program
    {
        static AmazonLambdaClient Client = new AmazonLambdaClient();
        static void Main(string[] args)
        {
            string input = "\"message\"";

            var request = new InvokeRequest()
            {
                FunctionName = "DefaultLambda",
                Payload = input
            };

            var response = Client.InvokeAsync(request).Result;

            Console.WriteLine($"Result => { new StreamReader(response.Payload).ReadToEnd() }");
        }
    }
}
