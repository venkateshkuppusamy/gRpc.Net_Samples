// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CalculatorPkg {
  public static partial class CalculatorService
  {
    static readonly string __ServiceName = "CalculatorPkg.CalculatorService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::CalculatorPkg.CalcRequest> __Marshaller_CalculatorPkg_CalcRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CalculatorPkg.CalcRequest.Parser));
    static readonly grpc::Marshaller<global::CalculatorPkg.CalcResponse> __Marshaller_CalculatorPkg_CalcResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CalculatorPkg.CalcResponse.Parser));
    static readonly grpc::Marshaller<global::CalculatorPkg.CalcDivRequest> __Marshaller_CalculatorPkg_CalcDivRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CalculatorPkg.CalcDivRequest.Parser));
    static readonly grpc::Marshaller<global::CalculatorPkg.CalcDivResponse> __Marshaller_CalculatorPkg_CalcDivResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CalculatorPkg.CalcDivResponse.Parser));

    static readonly grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse> __Method_Add = new grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_CalculatorPkg_CalcRequest,
        __Marshaller_CalculatorPkg_CalcResponse);

    static readonly grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse> __Method_Subtract = new grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subtract",
        __Marshaller_CalculatorPkg_CalcRequest,
        __Marshaller_CalculatorPkg_CalcResponse);

    static readonly grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse> __Method_Multiply = new grpc::Method<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiply",
        __Marshaller_CalculatorPkg_CalcRequest,
        __Marshaller_CalculatorPkg_CalcResponse);

    static readonly grpc::Method<global::CalculatorPkg.CalcDivRequest, global::CalculatorPkg.CalcDivResponse> __Method_Divide = new grpc::Method<global::CalculatorPkg.CalcDivRequest, global::CalculatorPkg.CalcDivResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Divide",
        __Marshaller_CalculatorPkg_CalcDivRequest,
        __Marshaller_CalculatorPkg_CalcDivResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CalculatorPkg.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalculatorService</summary>
    [grpc::BindServiceMethod(typeof(CalculatorService), "BindService")]
    public abstract partial class CalculatorServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CalculatorPkg.CalcResponse> Add(global::CalculatorPkg.CalcRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorPkg.CalcResponse> Subtract(global::CalculatorPkg.CalcRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorPkg.CalcResponse> Multiply(global::CalculatorPkg.CalcRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CalculatorPkg.CalcDivResponse> Divide(global::CalculatorPkg.CalcDivRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CalculatorService</summary>
    public partial class CalculatorServiceClient : grpc::ClientBase<CalculatorServiceClient>
    {
      /// <summary>Creates a new client for CalculatorService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CalculatorServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CalculatorService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CalculatorServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CalculatorServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CalculatorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::CalculatorPkg.CalcResponse Add(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Add(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorPkg.CalcResponse Add(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Add, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> AddAsync(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> AddAsync(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Add, null, options, request);
      }
      public virtual global::CalculatorPkg.CalcResponse Subtract(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subtract(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorPkg.CalcResponse Subtract(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Subtract, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> SubtractAsync(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubtractAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> SubtractAsync(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Subtract, null, options, request);
      }
      public virtual global::CalculatorPkg.CalcResponse Multiply(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Multiply(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorPkg.CalcResponse Multiply(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Multiply, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> MultiplyAsync(global::CalculatorPkg.CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MultiplyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcResponse> MultiplyAsync(global::CalculatorPkg.CalcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Multiply, null, options, request);
      }
      public virtual global::CalculatorPkg.CalcDivResponse Divide(global::CalculatorPkg.CalcDivRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Divide(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CalculatorPkg.CalcDivResponse Divide(global::CalculatorPkg.CalcDivRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Divide, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcDivResponse> DivideAsync(global::CalculatorPkg.CalcDivRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DivideAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CalculatorPkg.CalcDivResponse> DivideAsync(global::CalculatorPkg.CalcDivRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Divide, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CalculatorServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculatorServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalculatorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Subtract, serviceImpl.Subtract)
          .AddMethod(__Method_Multiply, serviceImpl.Multiply)
          .AddMethod(__Method_Divide, serviceImpl.Divide).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculatorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_Subtract, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(serviceImpl.Subtract));
      serviceBinder.AddMethod(__Method_Multiply, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorPkg.CalcRequest, global::CalculatorPkg.CalcResponse>(serviceImpl.Multiply));
      serviceBinder.AddMethod(__Method_Divide, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalculatorPkg.CalcDivRequest, global::CalculatorPkg.CalcDivResponse>(serviceImpl.Divide));
    }

  }
}
#endregion
