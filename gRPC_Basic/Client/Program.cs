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

            var result = client.Add(new CalculatorPkg.CalcRequest() { A = 2, B = 3 });

            Console.WriteLine($"Sum of 2 and 3 is {result.Result}");

            Console.ReadLine();
        }
    }
}
