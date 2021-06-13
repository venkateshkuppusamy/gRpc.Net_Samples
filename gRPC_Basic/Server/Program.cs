using Grpc.Core;
using Server.APIs;
using System;
using System.Threading.Tasks;
using static Grpc.Core.Server;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing gRPC server...");
            Grpc.Core.Server server = new Grpc.Core.Server() { Ports = { new Grpc.Core.ServerPort("localhost", 5001, ServerCredentials.Insecure) },
              Services = { CalculatorPkg.CalculatorService.BindService(new CalculatorAPI()) },
            };

            server.Start();
            Console.WriteLine("There Server is listention at 5001...");

            Console.WriteLine("Press any key to shutdown");
            Console.ReadLine();
            server.ShutdownAsync().Wait();

            
        }
    }
}
