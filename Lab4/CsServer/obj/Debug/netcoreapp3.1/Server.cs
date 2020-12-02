// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/server.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CsServer {

  /// <summary>Holder for reflection information generated from Protos/server.proto</summary>
  public static partial class ServerReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/server.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3Mvc2VydmVyLnByb3RvIiMKDFBob25lUmVxdWVzdBITCgtwaG9u",
            "ZU51bWJlchgBIAEoCSIrCg1QaG9uZVJlc3BvbnNlEhoKB21lc3NhZ2UYASAB",
            "KA4yCS5SZXNwb25zZSokCghSZXNwb25zZRIJCgVGT1VORBAAEg0KCU5PVF9G",
            "T1VORBABMkMKEVBob25lVmVyaWZpY2F0aW9uEi4KC1ZlcmlmeVBob25lEg0u",
            "UGhvbmVSZXF1ZXN0Gg4uUGhvbmVSZXNwb25zZSIAQguqAghDc1NlcnZlcmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CsServer.Response), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CsServer.PhoneRequest), global::CsServer.PhoneRequest.Parser, new[]{ "PhoneNumber" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CsServer.PhoneResponse), global::CsServer.PhoneResponse.Parser, new[]{ "Message" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Response {
    [pbr::OriginalName("FOUND")] Found = 0,
    [pbr::OriginalName("NOT_FOUND")] NotFound = 1,
  }

  #endregion

  #region Messages
  public sealed partial class PhoneRequest : pb::IMessage<PhoneRequest> {
    private static readonly pb::MessageParser<PhoneRequest> _parser = new pb::MessageParser<PhoneRequest>(() => new PhoneRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PhoneRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CsServer.ServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneRequest(PhoneRequest other) : this() {
      phoneNumber_ = other.phoneNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneRequest Clone() {
      return new PhoneRequest(this);
    }

    /// <summary>Field number for the "phoneNumber" field.</summary>
    public const int PhoneNumberFieldNumber = 1;
    private string phoneNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PhoneRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PhoneRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PhoneNumber != other.PhoneNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PhoneNumber.Length != 0) hash ^= PhoneNumber.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PhoneNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PhoneNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PhoneRequest other) {
      if (other == null) {
        return;
      }
      if (other.PhoneNumber.Length != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PhoneNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PhoneResponse : pb::IMessage<PhoneResponse> {
    private static readonly pb::MessageParser<PhoneResponse> _parser = new pb::MessageParser<PhoneResponse>(() => new PhoneResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PhoneResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CsServer.ServerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneResponse(PhoneResponse other) : this() {
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneResponse Clone() {
      return new PhoneResponse(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private global::CsServer.Response message_ = global::CsServer.Response.Found;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CsServer.Response Message {
      get { return message_; }
      set {
        message_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PhoneResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PhoneResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message != global::CsServer.Response.Found) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message != global::CsServer.Response.Found) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message != global::CsServer.Response.Found) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PhoneResponse other) {
      if (other == null) {
        return;
      }
      if (other.Message != global::CsServer.Response.Found) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Message = (global::CsServer.Response) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code