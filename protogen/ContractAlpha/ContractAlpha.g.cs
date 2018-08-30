// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ContractAlpha.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contracts.Grpc.Alpha {

  /// <summary>Holder for reflection information generated from ContractAlpha.proto</summary>
  public static partial class ContractAlphaReflection {

    #region Descriptor
    /// <summary>File descriptor for ContractAlpha.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContractAlphaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDb250cmFjdEFscGhhLnByb3RvEhRjb250cmFjdHMuZ3JwYy5hbHBoYRoe",
            "Z29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvIiEKE0dldEFscGhhQnlJ",
            "ZFJlcXVlc3QSCgoCSWQYASABKAUiTgoUR2V0QWxwaGFCeUlkUmVzcG9uc2US",
            "NgoLQWxwaGFPYmplY3QYASABKAsyIS5jb250cmFjdHMuZ3JwYy5hbHBoYS5B",
            "bHBoYU9iamVjdCJSCgtBbHBoYU9iamVjdBIKCgJJZBgBIAEoBRIqCgROYW1l",
            "GAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEgsKA0FnZRgD",
            "IAEoBTJ3CgxBbHBoYVNlcnZpY2USZwoMR2V0QWxwaGFCeUlkEikuY29udHJh",
            "Y3RzLmdycGMuYWxwaGEuR2V0QWxwaGFCeUlkUmVxdWVzdBoqLmNvbnRyYWN0",
            "cy5ncnBjLmFscGhhLkdldEFscGhhQnlJZFJlc3BvbnNlIgBCF6oCFENvbnRy",
            "YWN0cy5HcnBjLkFscGhhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.Grpc.Alpha.GetAlphaByIdRequest), global::Contracts.Grpc.Alpha.GetAlphaByIdRequest.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.Grpc.Alpha.GetAlphaByIdResponse), global::Contracts.Grpc.Alpha.GetAlphaByIdResponse.Parser, new[]{ "AlphaObject" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.Grpc.Alpha.AlphaObject), global::Contracts.Grpc.Alpha.AlphaObject.Parser, new[]{ "Id", "Name", "Age" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAlphaByIdRequest : pb::IMessage<GetAlphaByIdRequest> {
    private static readonly pb::MessageParser<GetAlphaByIdRequest> _parser = new pb::MessageParser<GetAlphaByIdRequest>(() => new GetAlphaByIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAlphaByIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.Grpc.Alpha.ContractAlphaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdRequest(GetAlphaByIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdRequest Clone() {
      return new GetAlphaByIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAlphaByIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAlphaByIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAlphaByIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
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
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAlphaByIdResponse : pb::IMessage<GetAlphaByIdResponse> {
    private static readonly pb::MessageParser<GetAlphaByIdResponse> _parser = new pb::MessageParser<GetAlphaByIdResponse>(() => new GetAlphaByIdResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAlphaByIdResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.Grpc.Alpha.ContractAlphaReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdResponse(GetAlphaByIdResponse other) : this() {
      AlphaObject = other.alphaObject_ != null ? other.AlphaObject.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAlphaByIdResponse Clone() {
      return new GetAlphaByIdResponse(this);
    }

    /// <summary>Field number for the "AlphaObject" field.</summary>
    public const int AlphaObjectFieldNumber = 1;
    private global::Contracts.Grpc.Alpha.AlphaObject alphaObject_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Contracts.Grpc.Alpha.AlphaObject AlphaObject {
      get { return alphaObject_; }
      set {
        alphaObject_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAlphaByIdResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAlphaByIdResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AlphaObject, other.AlphaObject)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (alphaObject_ != null) hash ^= AlphaObject.GetHashCode();
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
      if (alphaObject_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AlphaObject);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (alphaObject_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AlphaObject);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAlphaByIdResponse other) {
      if (other == null) {
        return;
      }
      if (other.alphaObject_ != null) {
        if (alphaObject_ == null) {
          alphaObject_ = new global::Contracts.Grpc.Alpha.AlphaObject();
        }
        AlphaObject.MergeFrom(other.AlphaObject);
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
            if (alphaObject_ == null) {
              alphaObject_ = new global::Contracts.Grpc.Alpha.AlphaObject();
            }
            input.ReadMessage(alphaObject_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AlphaObject : pb::IMessage<AlphaObject> {
    private static readonly pb::MessageParser<AlphaObject> _parser = new pb::MessageParser<AlphaObject>(() => new AlphaObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AlphaObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.Grpc.Alpha.ContractAlphaReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlphaObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlphaObject(AlphaObject other) : this() {
      id_ = other.id_;
      Name = other.Name;
      age_ = other.age_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlphaObject Clone() {
      return new AlphaObject(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }

    /// <summary>Field number for the "Age" field.</summary>
    public const int AgeFieldNumber = 3;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AlphaObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AlphaObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Age != other.Age) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (Age != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Age);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AlphaObject other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.Age != 0) {
        Age = other.Age;
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
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 24: {
            Age = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
