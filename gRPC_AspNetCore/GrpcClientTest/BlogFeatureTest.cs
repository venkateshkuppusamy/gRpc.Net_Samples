using Grpc.Core;
using GrpcClient;
using GrpcClient.Features;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GrpcClientTest
{
    [TestClass]
    public class BlogFeatureTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var mockclient = new Moq.Mock<BlogService.BlogServiceClient>();
            BlogFeature blogFeature = new BlogFeature();
            var blogresponse = ReturnAsyncUnaryCallResponse<BlogResponse>(new BlogResponse() { BlogId = Guid.NewGuid().ToString() });
            mockclient.Setup(m =>
                 m.CreateAsync(Moq.It.IsAny<BlogRequest>(), null, null, CancellationToken.None)
             ).Returns(blogresponse);

            var actual =  mockclient.Object.CreateAsync(new BlogRequest() { AuthorName = "Microsoft", Title = "Grpc Types", Contents = "Protocol Buffer (Protobuf) supports a range of native scalar value types. The following table lists them all with their equivalent C# type" }).GetAwaiter().GetResult();
            Assert.AreNotEqual(Guid.Empty.ToString(), actual.BlogId);
        }

        private AsyncUnaryCall<T> ReturnAsyncUnaryCallResponse<T>(T blogResponse)
        {
            return new AsyncUnaryCall<T>(Task.FromResult(blogResponse), Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
        }
    }
}
