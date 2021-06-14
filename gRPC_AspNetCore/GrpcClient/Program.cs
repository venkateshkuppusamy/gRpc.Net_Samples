using Grpc.Net.Client;
using System;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var response = new Greeter.GreeterClient(channel).SayHello(new HelloRequest() { Name = "Venki" });

            Console.WriteLine(response.Message);
            Console.Read();
        }
    }
}
