using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using GrpcClient.Middlewares;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static GrpcClient.BlogService;

namespace GrpcClient.Features
{
    public class BlogFeature
    {
        //private readonly BlogServiceClient blogClient;
        private readonly BlogServiceClient blogClient;
        public BlogFeature() {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var callInvoker =  channel.Intercept(new ClientInterceptor());

            blogClient = new BlogServiceClient(callInvoker);
        }

        public BlogFeature(BlogServiceClient blogServiceClient)
        {
            blogClient = blogServiceClient;
        }

        public Guid Create(BlogRequest blogRequest)
        {
            var createTask = blogClient.CreateAsync(blogRequest);
            var result = createTask.GetAwaiter().GetResult();
            Console.WriteLine($"Created Blog with ID {result.BlogId}, {result.AuthorName}, {result.Title} ");
            return Guid.Parse(result.BlogId);
        }

        public void Read(BlogReadRequest blogReadRequest)
        {
            try
            {
                var readTask = blogClient.ReadAsync(blogReadRequest);
                var result = readTask.GetAwaiter().GetResult();
                Console.WriteLine($"Read Blog ID {result.BlogId}, {result.AuthorName}, {result.Title} ");
            }
            catch (RpcException ex)
            {
                Console.WriteLine(ex.StatusCode);
            }
        }

        public async void ReadBlogLinesAsync(BlogReadRequest blogReadRequest, int maxLines)
        {
            var task = blogClient.ReadBlogLines(blogReadRequest);
            int counter = 1;
            
            while (await task.ResponseStream.MoveNext())
            {
                if(counter > maxLines)
                {
                    var tokensource = new CancellationToken();
                    await task.ResponseStream.MoveNext(tokensource);
                    break;
                }
                Console.WriteLine($"{counter}. {task.ResponseStream.Current.Line}");
                counter++;
            }
        }
    }
}
