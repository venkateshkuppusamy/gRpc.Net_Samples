using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient.Middlewares
{
    public class ClientInterceptor: Interceptor
    {
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            context= new ClientInterceptorContext<TRequest, TResponse>(context.Method, context.Host, context.Options.WithDeadline(DateTime.UtcNow.AddMilliseconds(6000)));
            return base.AsyncUnaryCall(request, context, continuation);
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            context.Options.WithDeadline(DateTime.UtcNow.AddMilliseconds(100));
            return base.BlockingUnaryCall(request, context, continuation);
        }
    }
}
