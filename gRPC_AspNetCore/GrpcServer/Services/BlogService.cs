using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class BlogService : GrpcServer.BlogService.BlogServiceBase {
        
        private static readonly List<Blog> _blogs = new List<Blog>();
        private readonly ILogger<BlogService> _logger;

        public BlogService(ILogger<BlogService> logger) {
            _logger = logger;
        }
        public override async Task<BlogResponse> Create(BlogRequest request, ServerCallContext context)
        {
            //await Task.Delay(0);
            _logger.LogInformation($"Create Blog by {request.AuthorName} and Title {request.Contents}");
            Blog blog = new Blog() { AuthorName = request.AuthorName, BlogId = Guid.NewGuid(), Title = request.Title, Contents = request.Title, ContentLines =  request.ContentLines };
            _blogs.Add(blog);

            return await Task.FromResult(new BlogResponse() { AuthorName = blog.AuthorName, Title = blog.Title, BlogId = blog.BlogId.ToString() });
           
        }

        public override async Task<BlogResponse> Read(BlogReadRequest request, ServerCallContext context)
        {
            await Task.Delay(3000);
            _logger.LogInformation($"Reading Blog {request.BlogId}");
            Blog blog = _blogs.Where(w => w.BlogId == Guid.Parse(request.BlogId)).FirstOrDefault();
            if (blog == null)
                throw new RpcException(new Status(StatusCode.NotFound,$"{Guid.Parse(request.BlogId)}"));

            return await Task.FromResult(new BlogResponse() { AuthorName = blog.AuthorName, BlogId = blog.BlogId.ToString(), Title = blog.Title });
            
        }

        public override async Task ReadBlogLines(BlogReadRequest request, IServerStreamWriter<BlogLinesResponse> responseStream, ServerCallContext context)
        {
            _logger.LogInformation($"Reading Blog lines {request.BlogId}");
            var blog = _blogs.FirstOrDefault(w => w.BlogId == Guid.Parse(request.BlogId));
            if (blog != null)
            {
                if (context.CancellationToken.IsCancellationRequested) {
                    _logger.LogInformation("Reading blog lines cancelled after line");
                    return; 
                }
                
                foreach (var item in blog.ContentLines)
                {
                    await responseStream.WriteAsync(new BlogLinesResponse() { Line = item });
                }
            }
        }
    }

    internal class Blog
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public Guid BlogId { get; set; }
        public string Contents { get; set; }
        public IEnumerable<string> ContentLines { get; set; }
    }
}
