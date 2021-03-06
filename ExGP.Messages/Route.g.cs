// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: common/route.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ExGP.Messages {

  /// <summary>Holder for reflection information generated from common/route.proto</summary>
  public static partial class RouteReflection {

    #region Descriptor
    /// <summary>File descriptor for common/route.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RouteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJjb21tb24vcm91dGUucHJvdG8SDUV4R1AuTWVzc2FnZXMilQIKBVJvdXRl",
            "Ej8KFnNvdXJjZV9zZXJ2aWNlX2FkZHJlc3MYASABKAsyHS5FeEdQLk1lc3Nh",
            "Z2VzLlNlcnZpY2VBZGRyZXNzSAASPQoVc291cmNlX2NsaWVudF9hZGRyZXNz",
            "GAIgASgLMhwuRXhHUC5NZXNzYWdlcy5DbGllbnRBZGRyZXNzSAASPQoUZGVz",
            "dF9zZXJ2aWNlX2FkZHJlc3MYAyABKAsyHS5FeEdQLk1lc3NhZ2VzLlNlcnZp",
            "Y2VBZGRyZXNzSAESOwoTZGVzdF9jbGllbnRfYWRkcmVzcxgEIAEoCzIcLkV4",
            "R1AuTWVzc2FnZXMuQ2xpZW50QWRkcmVzc0gBQggKBnNvdXJjZUIGCgRkZXN0",
            "Ij4KDlNlcnZpY2VBZGRyZXNzEiwKCnNlcnZpY2VfaWQYASABKA4yGC5FeEdQ",
            "Lk1lc3NhZ2VzLlNlcnZpY2VJZCJSCg1DbGllbnRBZGRyZXNzEhIKCmFjY291",
            "bnRfaWQYASABKAMSCwoDZ2lkGAIgASgJEg0KBWVtYWlsGAMgASgJEhEKCWFu",
            "b255bW91cxgEIAEoCCpFCglTZXJ2aWNlSWQSCgoGUk9VVEVSEAASCwoHQk9V",
            "TkNFUhABEggKBEFVVEgQAhILCgdGUklFTkRTEAMSCAoEQ0hBVBAEYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ExGP.Messages.ServiceId), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ExGP.Messages.Route), global::ExGP.Messages.Route.Parser, new[]{ "SourceServiceAddress", "SourceClientAddress", "DestServiceAddress", "DestClientAddress" }, new[]{ "Source", "Dest" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ExGP.Messages.ServiceAddress), global::ExGP.Messages.ServiceAddress.Parser, new[]{ "ServiceId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ExGP.Messages.ClientAddress), global::ExGP.Messages.ClientAddress.Parser, new[]{ "AccountId", "Gid", "Email", "Anonymous" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ServiceId {
    [pbr::OriginalName("ROUTER")] Router = 0,
    [pbr::OriginalName("BOUNCER")] Bouncer = 1,
    [pbr::OriginalName("AUTH")] Auth = 2,
    [pbr::OriginalName("FRIENDS")] Friends = 3,
    [pbr::OriginalName("CHAT")] Chat = 4,
  }

  #endregion

  #region Messages
  public sealed partial class Route : pb::IMessage<Route> {
    private static readonly pb::MessageParser<Route> _parser = new pb::MessageParser<Route>(() => new Route());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Route> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ExGP.Messages.RouteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Route() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Route(Route other) : this() {
      switch (other.SourceCase) {
        case SourceOneofCase.SourceServiceAddress:
          SourceServiceAddress = other.SourceServiceAddress.Clone();
          break;
        case SourceOneofCase.SourceClientAddress:
          SourceClientAddress = other.SourceClientAddress.Clone();
          break;
      }

      switch (other.DestCase) {
        case DestOneofCase.DestServiceAddress:
          DestServiceAddress = other.DestServiceAddress.Clone();
          break;
        case DestOneofCase.DestClientAddress:
          DestClientAddress = other.DestClientAddress.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Route Clone() {
      return new Route(this);
    }

    /// <summary>Field number for the "source_service_address" field.</summary>
    public const int SourceServiceAddressFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ExGP.Messages.ServiceAddress SourceServiceAddress {
      get { return sourceCase_ == SourceOneofCase.SourceServiceAddress ? (global::ExGP.Messages.ServiceAddress) source_ : null; }
      set {
        source_ = value;
        sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.SourceServiceAddress;
      }
    }

    /// <summary>Field number for the "source_client_address" field.</summary>
    public const int SourceClientAddressFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ExGP.Messages.ClientAddress SourceClientAddress {
      get { return sourceCase_ == SourceOneofCase.SourceClientAddress ? (global::ExGP.Messages.ClientAddress) source_ : null; }
      set {
        source_ = value;
        sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.SourceClientAddress;
      }
    }

    /// <summary>Field number for the "dest_service_address" field.</summary>
    public const int DestServiceAddressFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ExGP.Messages.ServiceAddress DestServiceAddress {
      get { return destCase_ == DestOneofCase.DestServiceAddress ? (global::ExGP.Messages.ServiceAddress) dest_ : null; }
      set {
        dest_ = value;
        destCase_ = value == null ? DestOneofCase.None : DestOneofCase.DestServiceAddress;
      }
    }

    /// <summary>Field number for the "dest_client_address" field.</summary>
    public const int DestClientAddressFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ExGP.Messages.ClientAddress DestClientAddress {
      get { return destCase_ == DestOneofCase.DestClientAddress ? (global::ExGP.Messages.ClientAddress) dest_ : null; }
      set {
        dest_ = value;
        destCase_ = value == null ? DestOneofCase.None : DestOneofCase.DestClientAddress;
      }
    }

    private object source_;
    /// <summary>Enum of possible cases for the "source" oneof.</summary>
    public enum SourceOneofCase {
      None = 0,
      SourceServiceAddress = 1,
      SourceClientAddress = 2,
    }
    private SourceOneofCase sourceCase_ = SourceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SourceOneofCase SourceCase {
      get { return sourceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSource() {
      sourceCase_ = SourceOneofCase.None;
      source_ = null;
    }

    private object dest_;
    /// <summary>Enum of possible cases for the "dest" oneof.</summary>
    public enum DestOneofCase {
      None = 0,
      DestServiceAddress = 3,
      DestClientAddress = 4,
    }
    private DestOneofCase destCase_ = DestOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DestOneofCase DestCase {
      get { return destCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDest() {
      destCase_ = DestOneofCase.None;
      dest_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Route);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Route other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SourceServiceAddress, other.SourceServiceAddress)) return false;
      if (!object.Equals(SourceClientAddress, other.SourceClientAddress)) return false;
      if (!object.Equals(DestServiceAddress, other.DestServiceAddress)) return false;
      if (!object.Equals(DestClientAddress, other.DestClientAddress)) return false;
      if (SourceCase != other.SourceCase) return false;
      if (DestCase != other.DestCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (sourceCase_ == SourceOneofCase.SourceServiceAddress) hash ^= SourceServiceAddress.GetHashCode();
      if (sourceCase_ == SourceOneofCase.SourceClientAddress) hash ^= SourceClientAddress.GetHashCode();
      if (destCase_ == DestOneofCase.DestServiceAddress) hash ^= DestServiceAddress.GetHashCode();
      if (destCase_ == DestOneofCase.DestClientAddress) hash ^= DestClientAddress.GetHashCode();
      hash ^= (int) sourceCase_;
      hash ^= (int) destCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (sourceCase_ == SourceOneofCase.SourceServiceAddress) {
        output.WriteRawTag(10);
        output.WriteMessage(SourceServiceAddress);
      }
      if (sourceCase_ == SourceOneofCase.SourceClientAddress) {
        output.WriteRawTag(18);
        output.WriteMessage(SourceClientAddress);
      }
      if (destCase_ == DestOneofCase.DestServiceAddress) {
        output.WriteRawTag(26);
        output.WriteMessage(DestServiceAddress);
      }
      if (destCase_ == DestOneofCase.DestClientAddress) {
        output.WriteRawTag(34);
        output.WriteMessage(DestClientAddress);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (sourceCase_ == SourceOneofCase.SourceServiceAddress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourceServiceAddress);
      }
      if (sourceCase_ == SourceOneofCase.SourceClientAddress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourceClientAddress);
      }
      if (destCase_ == DestOneofCase.DestServiceAddress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DestServiceAddress);
      }
      if (destCase_ == DestOneofCase.DestClientAddress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DestClientAddress);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Route other) {
      if (other == null) {
        return;
      }
      switch (other.SourceCase) {
        case SourceOneofCase.SourceServiceAddress:
          SourceServiceAddress = other.SourceServiceAddress;
          break;
        case SourceOneofCase.SourceClientAddress:
          SourceClientAddress = other.SourceClientAddress;
          break;
      }

      switch (other.DestCase) {
        case DestOneofCase.DestServiceAddress:
          DestServiceAddress = other.DestServiceAddress;
          break;
        case DestOneofCase.DestClientAddress:
          DestClientAddress = other.DestClientAddress;
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            global::ExGP.Messages.ServiceAddress subBuilder = new global::ExGP.Messages.ServiceAddress();
            if (sourceCase_ == SourceOneofCase.SourceServiceAddress) {
              subBuilder.MergeFrom(SourceServiceAddress);
            }
            input.ReadMessage(subBuilder);
            SourceServiceAddress = subBuilder;
            break;
          }
          case 18: {
            global::ExGP.Messages.ClientAddress subBuilder = new global::ExGP.Messages.ClientAddress();
            if (sourceCase_ == SourceOneofCase.SourceClientAddress) {
              subBuilder.MergeFrom(SourceClientAddress);
            }
            input.ReadMessage(subBuilder);
            SourceClientAddress = subBuilder;
            break;
          }
          case 26: {
            global::ExGP.Messages.ServiceAddress subBuilder = new global::ExGP.Messages.ServiceAddress();
            if (destCase_ == DestOneofCase.DestServiceAddress) {
              subBuilder.MergeFrom(DestServiceAddress);
            }
            input.ReadMessage(subBuilder);
            DestServiceAddress = subBuilder;
            break;
          }
          case 34: {
            global::ExGP.Messages.ClientAddress subBuilder = new global::ExGP.Messages.ClientAddress();
            if (destCase_ == DestOneofCase.DestClientAddress) {
              subBuilder.MergeFrom(DestClientAddress);
            }
            input.ReadMessage(subBuilder);
            DestClientAddress = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServiceAddress : pb::IMessage<ServiceAddress> {
    private static readonly pb::MessageParser<ServiceAddress> _parser = new pb::MessageParser<ServiceAddress>(() => new ServiceAddress());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServiceAddress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ExGP.Messages.RouteReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceAddress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceAddress(ServiceAddress other) : this() {
      serviceId_ = other.serviceId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceAddress Clone() {
      return new ServiceAddress(this);
    }

    /// <summary>Field number for the "service_id" field.</summary>
    public const int ServiceIdFieldNumber = 1;
    private global::ExGP.Messages.ServiceId serviceId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ExGP.Messages.ServiceId ServiceId {
      get { return serviceId_; }
      set {
        serviceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServiceAddress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServiceAddress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceId != other.ServiceId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServiceId != 0) hash ^= ServiceId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ServiceId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ServiceId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServiceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ServiceId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServiceAddress other) {
      if (other == null) {
        return;
      }
      if (other.ServiceId != 0) {
        ServiceId = other.ServiceId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            serviceId_ = (global::ExGP.Messages.ServiceId) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientAddress : pb::IMessage<ClientAddress> {
    private static readonly pb::MessageParser<ClientAddress> _parser = new pb::MessageParser<ClientAddress>(() => new ClientAddress());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientAddress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ExGP.Messages.RouteReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientAddress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientAddress(ClientAddress other) : this() {
      accountId_ = other.accountId_;
      gid_ = other.gid_;
      email_ = other.email_;
      anonymous_ = other.anonymous_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientAddress Clone() {
      return new ClientAddress(this);
    }

    /// <summary>Field number for the "account_id" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private long accountId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    /// <summary>Field number for the "gid" field.</summary>
    public const int GidFieldNumber = 2;
    private string gid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Gid {
      get { return gid_; }
      set {
        gid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "anonymous" field.</summary>
    public const int AnonymousFieldNumber = 4;
    private bool anonymous_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Anonymous {
      get { return anonymous_; }
      set {
        anonymous_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientAddress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientAddress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      if (Gid != other.Gid) return false;
      if (Email != other.Email) return false;
      if (Anonymous != other.Anonymous) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccountId != 0L) hash ^= AccountId.GetHashCode();
      if (Gid.Length != 0) hash ^= Gid.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Anonymous != false) hash ^= Anonymous.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(AccountId);
      }
      if (Gid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Gid);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (Anonymous != false) {
        output.WriteRawTag(32);
        output.WriteBool(Anonymous);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccountId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AccountId);
      }
      if (Gid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Gid);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Anonymous != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientAddress other) {
      if (other == null) {
        return;
      }
      if (other.AccountId != 0L) {
        AccountId = other.AccountId;
      }
      if (other.Gid.Length != 0) {
        Gid = other.Gid;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Anonymous != false) {
        Anonymous = other.Anonymous;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            AccountId = input.ReadInt64();
            break;
          }
          case 18: {
            Gid = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 32: {
            Anonymous = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
