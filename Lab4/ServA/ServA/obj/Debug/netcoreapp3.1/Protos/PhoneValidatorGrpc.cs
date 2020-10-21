// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/PhoneValidator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PhoneValidatorProtos {
  public static partial class Numberer
  {
    static readonly string __ServiceName = "Numberer";

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

    static readonly grpc::Marshaller<global::PhoneValidatorProtos.NumberRequest> __Marshaller_NumberRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneValidatorProtos.NumberRequest.Parser));
    static readonly grpc::Marshaller<global::PhoneValidatorProtos.ResultReply> __Marshaller_ResultReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PhoneValidatorProtos.ResultReply.Parser));

    static readonly grpc::Method<global::PhoneValidatorProtos.NumberRequest, global::PhoneValidatorProtos.ResultReply> __Method_ValidateNumber = new grpc::Method<global::PhoneValidatorProtos.NumberRequest, global::PhoneValidatorProtos.ResultReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ValidateNumber",
        __Marshaller_NumberRequest,
        __Marshaller_ResultReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PhoneValidatorProtos.PhoneValidatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Numberer</summary>
    public partial class NumbererClient : grpc::ClientBase<NumbererClient>
    {
      /// <summary>Creates a new client for Numberer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NumbererClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Numberer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NumbererClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NumbererClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NumbererClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::PhoneValidatorProtos.ResultReply ValidateNumber(global::PhoneValidatorProtos.NumberRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateNumber(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PhoneValidatorProtos.ResultReply ValidateNumber(global::PhoneValidatorProtos.NumberRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ValidateNumber, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PhoneValidatorProtos.ResultReply> ValidateNumberAsync(global::PhoneValidatorProtos.NumberRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateNumberAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PhoneValidatorProtos.ResultReply> ValidateNumberAsync(global::PhoneValidatorProtos.NumberRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ValidateNumber, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NumbererClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NumbererClient(configuration);
      }
    }

  }
}
#endregion