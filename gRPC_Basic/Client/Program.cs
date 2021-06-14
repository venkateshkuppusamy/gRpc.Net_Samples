using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing gRPC client...");

            Grpc.Core.Channel channel = new Grpc.Core.Channel("localhost", 5001, Grpc.Core.ChannelCredentials.Insecure);

            var client = new CalculatorPkg.CalculatorService.CalculatorServiceClient(channel);
            //Add(client);
            //Subtract(client);
            Multiply(client);
            //Divide(client);

            Console.ReadLine();
        }

        private static void Add(CalculatorPkg.CalculatorService.CalculatorServiceClient client)
        {
            var result = client.Add(new CalculatorPkg.CalcRequest() { A = 2, B = 3 });

            Console.WriteLine($"Sum of 2 and 3 is {result.Result}");
        }

        private static void Subtract(CalculatorPkg.CalculatorService.CalculatorServiceClient client)
        {
            var result = client.Subtract(new CalculatorPkg.CalcRequest() { A = 2, B = 3 });

            Console.WriteLine($"Difference  of 2 and 3 is {result.Result}");
        }

        private static void Multiply(CalculatorPkg.CalculatorService.CalculatorServiceClient client)
        {
            try
            {
                var result = client.Multiply(new CalculatorPkg.CalcRequest() { A = 2, B = 3 }, deadline: DateTime.UtcNow.AddSeconds(1));

                Console.WriteLine($"Multiplication of 2 and 3 is {result.Result}");
            }
            catch (Grpc.Core.RpcException ex)
            {
                Console.WriteLine($"Error in Muliply call with message {ex.StatusCode} ");
            }
        }

        private static void Divide(CalculatorPkg.CalculatorService.CalculatorServiceClient client)
        {
            try
            {
                var result = client.Divide(new CalculatorPkg.CalcDivRequest() { A = 2, B = 0 });
                Console.WriteLine($"Division of 2 by 3 is {result.Result}");
            }
            catch (Grpc.Core.RpcException ex)
            {
                Console.WriteLine($"Error in Divide call with status {ex.Status.StatusCode} and reason {ex.Status.Detail}");
            }
            
        }
    }
}
