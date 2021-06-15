using Google.Protobuf.Collections;
using Grpc.Net.Client;
using GrpcClient.Features;
using System;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var response = new Greeter.GreeterClient(channel).SayHello(new HelloRequest() { Name = "Venki" });
            //Console.WriteLine(response.Message);

            BlogFeature blogFeature = new BlogFeature();
            
            BlogRequest blogRequest= new BlogRequest() { AuthorName = "Microsoft", Title = "Grpc Types", Contents = "Protocol Buffer (Protobuf) supports a range of native scalar value types. The following table lists them all with their equivalent C# type" };
            blogRequest.ContentLines.AddRange(new string[]{
                "Code - first gRPC uses .NET types to define service and message contracts.",
                ".NET service and data contract types can be shared between the .NET server and clients.",
                "Avoids the need to define contracts in .proto files and code generation.",
                "Code - first isn't recommended in polyglot systems with multiple languages. .NET service and data contract types can't be used with non -.NET platforms.",
                "To call a gRPC service written using code-first, other platforms must create a.proto contract that matches the service."
            });

            Guid BlogId= blogFeature.Create(blogRequest);

            blogFeature.Read(new BlogReadRequest() { BlogId = BlogId.ToString() });
            
            blogFeature.ReadBlogLinesAsync(new BlogReadRequest() { BlogId = BlogId.ToString() },2);
            
            Console.Read();
        }
    }
}
