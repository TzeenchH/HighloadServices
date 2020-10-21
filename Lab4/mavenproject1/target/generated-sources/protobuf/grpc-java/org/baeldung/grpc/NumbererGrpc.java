package org.baeldung.grpc;

import static io.grpc.stub.ClientCalls.asyncUnaryCall;
import static io.grpc.stub.ClientCalls.asyncServerStreamingCall;
import static io.grpc.stub.ClientCalls.asyncClientStreamingCall;
import static io.grpc.stub.ClientCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ClientCalls.blockingUnaryCall;
import static io.grpc.stub.ClientCalls.blockingServerStreamingCall;
import static io.grpc.stub.ClientCalls.futureUnaryCall;
import static io.grpc.MethodDescriptor.generateFullMethodName;
import static io.grpc.stub.ServerCalls.asyncUnaryCall;
import static io.grpc.stub.ServerCalls.asyncServerStreamingCall;
import static io.grpc.stub.ServerCalls.asyncClientStreamingCall;
import static io.grpc.stub.ServerCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedStreamingCall;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler (version 1.4.0)",
    comments = "Source: PhoneValidator.proto")
public final class NumbererGrpc {

  private NumbererGrpc() {}

  public static final String SERVICE_NAME = "org.baeldung.grpc.Numberer";

  // Static method descriptors that strictly reflect the proto.
  @io.grpc.ExperimentalApi("https://github.com/grpc/grpc-java/issues/1901")
  public static final io.grpc.MethodDescriptor<org.baeldung.grpc.NumberRequest,
      org.baeldung.grpc.ResultReply> METHOD_VALIDATE_NUMBER =
      io.grpc.MethodDescriptor.<org.baeldung.grpc.NumberRequest, org.baeldung.grpc.ResultReply>newBuilder()
          .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
          .setFullMethodName(generateFullMethodName(
              "org.baeldung.grpc.Numberer", "ValidateNumber"))
          .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
              org.baeldung.grpc.NumberRequest.getDefaultInstance()))
          .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
              org.baeldung.grpc.ResultReply.getDefaultInstance()))
          .build();

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static NumbererStub newStub(io.grpc.Channel channel) {
    return new NumbererStub(channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static NumbererBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    return new NumbererBlockingStub(channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static NumbererFutureStub newFutureStub(
      io.grpc.Channel channel) {
    return new NumbererFutureStub(channel);
  }

  /**
   */
  public static abstract class NumbererImplBase implements io.grpc.BindableService {

    /**
     */
    public void validateNumber(org.baeldung.grpc.NumberRequest request,
        io.grpc.stub.StreamObserver<org.baeldung.grpc.ResultReply> responseObserver) {
      asyncUnimplementedUnaryCall(METHOD_VALIDATE_NUMBER, responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            METHOD_VALIDATE_NUMBER,
            asyncUnaryCall(
              new MethodHandlers<
                org.baeldung.grpc.NumberRequest,
                org.baeldung.grpc.ResultReply>(
                  this, METHODID_VALIDATE_NUMBER)))
          .build();
    }
  }

  /**
   */
  public static final class NumbererStub extends io.grpc.stub.AbstractStub<NumbererStub> {
    private NumbererStub(io.grpc.Channel channel) {
      super(channel);
    }

    private NumbererStub(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected NumbererStub build(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      return new NumbererStub(channel, callOptions);
    }

    /**
     */
    public void validateNumber(org.baeldung.grpc.NumberRequest request,
        io.grpc.stub.StreamObserver<org.baeldung.grpc.ResultReply> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(METHOD_VALIDATE_NUMBER, getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class NumbererBlockingStub extends io.grpc.stub.AbstractStub<NumbererBlockingStub> {
    private NumbererBlockingStub(io.grpc.Channel channel) {
      super(channel);
    }

    private NumbererBlockingStub(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected NumbererBlockingStub build(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      return new NumbererBlockingStub(channel, callOptions);
    }

    /**
     */
    public org.baeldung.grpc.ResultReply validateNumber(org.baeldung.grpc.NumberRequest request) {
      return blockingUnaryCall(
          getChannel(), METHOD_VALIDATE_NUMBER, getCallOptions(), request);
    }
  }

  /**
   */
  public static final class NumbererFutureStub extends io.grpc.stub.AbstractStub<NumbererFutureStub> {
    private NumbererFutureStub(io.grpc.Channel channel) {
      super(channel);
    }

    private NumbererFutureStub(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected NumbererFutureStub build(io.grpc.Channel channel,
        io.grpc.CallOptions callOptions) {
      return new NumbererFutureStub(channel, callOptions);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<org.baeldung.grpc.ResultReply> validateNumber(
        org.baeldung.grpc.NumberRequest request) {
      return futureUnaryCall(
          getChannel().newCall(METHOD_VALIDATE_NUMBER, getCallOptions()), request);
    }
  }

  private static final int METHODID_VALIDATE_NUMBER = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final NumbererImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(NumbererImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_VALIDATE_NUMBER:
          serviceImpl.validateNumber((org.baeldung.grpc.NumberRequest) request,
              (io.grpc.stub.StreamObserver<org.baeldung.grpc.ResultReply>) responseObserver);
          break;
        default:
          throw new AssertionError();
      }
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public io.grpc.stub.StreamObserver<Req> invoke(
        io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        default:
          throw new AssertionError();
      }
    }
  }

  private static final class NumbererDescriptorSupplier implements io.grpc.protobuf.ProtoFileDescriptorSupplier {
    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return org.baeldung.grpc.PhoneValidator.getDescriptor();
    }
  }

  private static volatile io.grpc.ServiceDescriptor serviceDescriptor;

  public static io.grpc.ServiceDescriptor getServiceDescriptor() {
    io.grpc.ServiceDescriptor result = serviceDescriptor;
    if (result == null) {
      synchronized (NumbererGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new NumbererDescriptorSupplier())
              .addMethod(METHOD_VALIDATE_NUMBER)
              .build();
        }
      }
    }
    return result;
  }
}
