// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tbmatch/session.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tbmatch {

  /// <summary>Holder for reflection information generated from tbmatch/session.proto</summary>
  public static partial class SessionReflection {

    #region Descriptor
    /// <summary>File descriptor for tbmatch/session.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChV0Ym1hdGNoL3Nlc3Npb24ucHJvdG8SB3RibWF0Y2gaEXRicnBjL3RicnBj",
            "LnByb3RvImYKDExvZ2luUmVxdWVzdBINCgVsb2dpbhgBIAEoCRIQCghwYXNz",
            "d29yZBgCIAEoCRIVCg1idWlsZF92ZXJzaW9uGAUgASgJEh4KFl9fZGVwcmVj",
            "YXRlZF9yZW1vdGVfaXAYCiABKAkiTAoaR2V0R2FtZVNlc3Npb25UaWNrZXRS",
            "ZXN1bHQSHwoEZ2FtZRgBIAEoDjIRLnRibWF0Y2guR2FtZVR5cGUSDQoFbm9u",
            "Y2UYAiABKAkiZwoeUmVkZWVtR2FtZVNlc3Npb25UaWNrZXRSZXF1ZXN0Eh8K",
            "BGdhbWUYASABKA4yES50Ym1hdGNoLkdhbWVUeXBlEg0KBW5vbmNlGAIgASgJ",
            "EhUKDWJ1aWxkX3ZlcnNpb24YBSABKAkiXAobR2V0R2FtZVNlc3Npb25UaWNr",
            "ZXRSZXF1ZXN0Eh8KBGdhbWUYASABKA4yES50Ym1hdGNoLkdhbWVUeXBlEhwK",
            "FGNsaWVudF9idWlsZF92ZXJzaW9uGAIgASgJKjUKCEdhbWVUeXBlEhIKDkdB",
            "TUVfVFlQRV9aRVJPEAASFQoRR1RfUklTSU5HX1RIVU5ERVIQZDKxAgoOU2Vz",
            "c2lvblNlcnZpY2USMgoFTG9naW4SFS50Ym1hdGNoLkxvZ2luUmVxdWVzdBoM",
            "LnRicnBjLkVtcHR5IgTI8xgAEmcKFEdldEdhbWVTZXNzaW9uVGlja2V0EiQu",
            "dGJtYXRjaC5HZXRHYW1lU2Vzc2lvblRpY2tldFJlcXVlc3QaIy50Ym1hdGNo",
            "LkdldEdhbWVTZXNzaW9uVGlja2V0UmVzdWx0IgTI8xgBElYKF1JlZGVlbUdh",
            "bWVTZXNzaW9uVGlja2V0EicudGJtYXRjaC5SZWRlZW1HYW1lU2Vzc2lvblRp",
            "Y2tldFJlcXVlc3QaDC50YnJwYy5FbXB0eSIEyPMYABIqCgZMb2dvdXQSDC50",
            "YnJwYy5FbXB0eRoMLnRicnBjLkVtcHR5IgTI8xgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tbrpc.TbrpcReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Tbmatch.GameType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tbmatch.LoginRequest), global::Tbmatch.LoginRequest.Parser, new[]{ "Login", "Password", "BuildVersion", "DeprecatedRemoteIp" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tbmatch.GetGameSessionTicketResult), global::Tbmatch.GetGameSessionTicketResult.Parser, new[]{ "Game", "Nonce" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tbmatch.RedeemGameSessionTicketRequest), global::Tbmatch.RedeemGameSessionTicketRequest.Parser, new[]{ "Game", "Nonce", "BuildVersion" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tbmatch.GetGameSessionTicketRequest), global::Tbmatch.GetGameSessionTicketRequest.Parser, new[]{ "Game", "ClientBuildVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum GameType {
    [pbr::OriginalName("GAME_TYPE_ZERO")] Zero = 0,
    /// <summary>
    /// Rising Thunder.
    /// </summary>
    [pbr::OriginalName("GT_RISING_THUNDER")] GtRisingThunder = 100,
  }

  #endregion

  #region Messages
  public sealed partial class LoginRequest : pb::IMessage<LoginRequest> {
    private static readonly pb::MessageParser<LoginRequest> _parser = new pb::MessageParser<LoginRequest>(() => new LoginRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tbmatch.SessionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest(LoginRequest other) : this() {
      login_ = other.login_;
      password_ = other.password_;
      buildVersion_ = other.buildVersion_;
      DeprecatedRemoteIp_ = other.DeprecatedRemoteIp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest Clone() {
      return new LoginRequest(this);
    }

    /// <summary>Field number for the "login" field.</summary>
    public const int LoginFieldNumber = 1;
    private string login_ = "";
    /// <summary>
    /// Either handle or e-mail address can be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 5;
    private string buildVersion_ = "";
    /// <summary>
    /// Client build.  May require certain version to login.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "__deprecated_remote_ip" field.</summary>
    public const int DeprecatedRemoteIpFieldNumber = 10;
    private string DeprecatedRemoteIp_ = "";
    /// <summary>
    /// Remote IP now passed via XFF header by TBFE
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeprecatedRemoteIp {
      get { return DeprecatedRemoteIp_; }
      set {
        DeprecatedRemoteIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Login != other.Login) return false;
      if (Password != other.Password) return false;
      if (BuildVersion != other.BuildVersion) return false;
      if (DeprecatedRemoteIp != other.DeprecatedRemoteIp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
      if (DeprecatedRemoteIp.Length != 0) hash ^= DeprecatedRemoteIp.GetHashCode();
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
      if (Login.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Login);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(BuildVersion);
      }
      if (DeprecatedRemoteIp.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(DeprecatedRemoteIp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (DeprecatedRemoteIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeprecatedRemoteIp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginRequest other) {
      if (other == null) {
        return;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
      }
      if (other.DeprecatedRemoteIp.Length != 0) {
        DeprecatedRemoteIp = other.DeprecatedRemoteIp;
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
            Login = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 42: {
            BuildVersion = input.ReadString();
            break;
          }
          case 82: {
            DeprecatedRemoteIp = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetGameSessionTicketResult : pb::IMessage<GetGameSessionTicketResult> {
    private static readonly pb::MessageParser<GetGameSessionTicketResult> _parser = new pb::MessageParser<GetGameSessionTicketResult>(() => new GetGameSessionTicketResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGameSessionTicketResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tbmatch.SessionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketResult(GetGameSessionTicketResult other) : this() {
      game_ = other.game_;
      nonce_ = other.nonce_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketResult Clone() {
      return new GetGameSessionTicketResult(this);
    }

    /// <summary>Field number for the "game" field.</summary>
    public const int GameFieldNumber = 1;
    private global::Tbmatch.GameType game_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tbmatch.GameType Game {
      get { return game_; }
      set {
        game_ = value;
      }
    }

    /// <summary>Field number for the "nonce" field.</summary>
    public const int NonceFieldNumber = 2;
    private string nonce_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nonce {
      get { return nonce_; }
      set {
        nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGameSessionTicketResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGameSessionTicketResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Game != other.Game) return false;
      if (Nonce != other.Nonce) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Game != 0) hash ^= Game.GetHashCode();
      if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
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
      if (Game != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Game);
      }
      if (Nonce.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nonce);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Game != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Game);
      }
      if (Nonce.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nonce);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGameSessionTicketResult other) {
      if (other == null) {
        return;
      }
      if (other.Game != 0) {
        Game = other.Game;
      }
      if (other.Nonce.Length != 0) {
        Nonce = other.Nonce;
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
            game_ = (global::Tbmatch.GameType) input.ReadEnum();
            break;
          }
          case 18: {
            Nonce = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RedeemGameSessionTicketRequest : pb::IMessage<RedeemGameSessionTicketRequest> {
    private static readonly pb::MessageParser<RedeemGameSessionTicketRequest> _parser = new pb::MessageParser<RedeemGameSessionTicketRequest>(() => new RedeemGameSessionTicketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemGameSessionTicketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tbmatch.SessionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGameSessionTicketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGameSessionTicketRequest(RedeemGameSessionTicketRequest other) : this() {
      game_ = other.game_;
      nonce_ = other.nonce_;
      buildVersion_ = other.buildVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGameSessionTicketRequest Clone() {
      return new RedeemGameSessionTicketRequest(this);
    }

    /// <summary>Field number for the "game" field.</summary>
    public const int GameFieldNumber = 1;
    private global::Tbmatch.GameType game_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tbmatch.GameType Game {
      get { return game_; }
      set {
        game_ = value;
      }
    }

    /// <summary>Field number for the "nonce" field.</summary>
    public const int NonceFieldNumber = 2;
    private string nonce_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nonce {
      get { return nonce_; }
      set {
        nonce_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 5;
    private string buildVersion_ = "";
    /// <summary>
    /// Client build.  Server may require a certain version to login.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemGameSessionTicketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemGameSessionTicketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Game != other.Game) return false;
      if (Nonce != other.Nonce) return false;
      if (BuildVersion != other.BuildVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Game != 0) hash ^= Game.GetHashCode();
      if (Nonce.Length != 0) hash ^= Nonce.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
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
      if (Game != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Game);
      }
      if (Nonce.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nonce);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(BuildVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Game != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Game);
      }
      if (Nonce.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nonce);
      }
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemGameSessionTicketRequest other) {
      if (other == null) {
        return;
      }
      if (other.Game != 0) {
        Game = other.Game;
      }
      if (other.Nonce.Length != 0) {
        Nonce = other.Nonce;
      }
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
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
            game_ = (global::Tbmatch.GameType) input.ReadEnum();
            break;
          }
          case 18: {
            Nonce = input.ReadString();
            break;
          }
          case 42: {
            BuildVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetGameSessionTicketRequest : pb::IMessage<GetGameSessionTicketRequest> {
    private static readonly pb::MessageParser<GetGameSessionTicketRequest> _parser = new pb::MessageParser<GetGameSessionTicketRequest>(() => new GetGameSessionTicketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGameSessionTicketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tbmatch.SessionReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketRequest(GetGameSessionTicketRequest other) : this() {
      game_ = other.game_;
      clientBuildVersion_ = other.clientBuildVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGameSessionTicketRequest Clone() {
      return new GetGameSessionTicketRequest(this);
    }

    /// <summary>Field number for the "game" field.</summary>
    public const int GameFieldNumber = 1;
    private global::Tbmatch.GameType game_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tbmatch.GameType Game {
      get { return game_; }
      set {
        game_ = value;
      }
    }

    /// <summary>Field number for the "client_build_version" field.</summary>
    public const int ClientBuildVersionFieldNumber = 2;
    private string clientBuildVersion_ = "";
    /// <summary>
    /// Build number of the client.  If set, checks that the build is allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientBuildVersion {
      get { return clientBuildVersion_; }
      set {
        clientBuildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGameSessionTicketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGameSessionTicketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Game != other.Game) return false;
      if (ClientBuildVersion != other.ClientBuildVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Game != 0) hash ^= Game.GetHashCode();
      if (ClientBuildVersion.Length != 0) hash ^= ClientBuildVersion.GetHashCode();
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
      if (Game != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Game);
      }
      if (ClientBuildVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClientBuildVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Game != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Game);
      }
      if (ClientBuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientBuildVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGameSessionTicketRequest other) {
      if (other == null) {
        return;
      }
      if (other.Game != 0) {
        Game = other.Game;
      }
      if (other.ClientBuildVersion.Length != 0) {
        ClientBuildVersion = other.ClientBuildVersion;
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
            game_ = (global::Tbmatch.GameType) input.ReadEnum();
            break;
          }
          case 18: {
            ClientBuildVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
