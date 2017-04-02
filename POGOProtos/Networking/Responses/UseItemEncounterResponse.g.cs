// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/UseItemEncounterResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemEncounterResponse.proto</summary>
  public static partial class UseItemEncounterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemEncounterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemEncounterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1FbmNv",
            "dW50ZXJSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcxowUE9HT1Byb3Rvcy9EYXRhL0NhcHR1cmUvQ2FwdHVyZVByb2Jh",
            "YmlsaXR5LnByb3RvGiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1J",
            "ZC5wcm90byLpAgoYVXNlSXRlbUVuY291bnRlclJlc3BvbnNlElAKBnN0YXR1",
            "cxgBIAEoDjJALlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuVXNl",
            "SXRlbUVuY291bnRlclJlc3BvbnNlLlN0YXR1cxJIChNjYXB0dXJlX3Byb2Jh",
            "YmlsaXR5GAIgASgLMisuUE9HT1Byb3Rvcy5EYXRhLkNhcHR1cmUuQ2FwdHVy",
            "ZVByb2JhYmlsaXR5EjYKC2FjdGl2ZV9pdGVtGAMgASgOMiEuUE9HT1Byb3Rv",
            "cy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQieQoGU3RhdHVzEgsKB1NVQ0NFU1MQ",
            "ABIVChFBTFJFQURZX0NPTVBMRVRFRBABEhYKEkFDVElWRV9JVEVNX0VYSVNU",
            "UxACEhgKFE5PX0lURU1fSU5fSU5WRU5UT1JZEAMSGQoVSU5WQUxJRF9JVEVN",
            "X0NBVEVHT1JZEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemEncounterResponse), global::POGOProtos.Networking.Responses.UseItemEncounterResponse.Parser, new[]{ "Status", "CaptureProbability", "ActiveItem" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemEncounterResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemEncounterResponse : pb::IMessage<UseItemEncounterResponse> {
    private static readonly pb::MessageParser<UseItemEncounterResponse> _parser = new pb::MessageParser<UseItemEncounterResponse>(() => new UseItemEncounterResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemEncounterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemEncounterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEncounterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEncounterResponse(UseItemEncounterResponse other) : this() {
      status_ = other.status_;
      CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
      activeItem_ = other.activeItem_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEncounterResponse Clone() {
      return new UseItemEncounterResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemEncounterResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemEncounterResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "capture_probability" field.</summary>
    public const int CaptureProbabilityFieldNumber = 2;
    private global::POGOProtos.Data.Capture.CaptureProbability captureProbability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureProbability CaptureProbability {
      get { return captureProbability_; }
      set {
        captureProbability_ = value;
      }
    }

    /// <summary>Field number for the "active_item" field.</summary>
    public const int ActiveItemFieldNumber = 3;
    private global::POGOProtos.Inventory.Item.ItemId activeItem_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ActiveItem {
      get { return activeItem_; }
      set {
        activeItem_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemEncounterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemEncounterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(CaptureProbability, other.CaptureProbability)) return false;
      if (ActiveItem != other.ActiveItem) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
      if (ActiveItem != 0) hash ^= ActiveItem.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (captureProbability_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CaptureProbability);
      }
      if (ActiveItem != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ActiveItem);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (captureProbability_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
      }
      if (ActiveItem != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActiveItem);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemEncounterResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.captureProbability_ != null) {
        if (captureProbability_ == null) {
          captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
        }
        CaptureProbability.MergeFrom(other.CaptureProbability);
      }
      if (other.ActiveItem != 0) {
        ActiveItem = other.ActiveItem;
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
            status_ = (global::POGOProtos.Networking.Responses.UseItemEncounterResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (captureProbability_ == null) {
              captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
            }
            input.ReadMessage(captureProbability_);
            break;
          }
          case 24: {
            activeItem_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemEncounterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("SUCCESS")] Success = 0,
        [pbr::OriginalName("ALREADY_COMPLETED")] AlreadyCompleted = 1,
        [pbr::OriginalName("ACTIVE_ITEM_EXISTS")] ActiveItemExists = 2,
        [pbr::OriginalName("NO_ITEM_IN_INVENTORY")] NoItemInInventory = 3,
        [pbr::OriginalName("INVALID_ITEM_CATEGORY")] InvalidItemCategory = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code