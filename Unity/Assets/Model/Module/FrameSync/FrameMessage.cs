// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: FrameMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ETModel {

  #region Messages
  public partial class OneFrameMessage : pb::IMessage {
    private static readonly pb::MessageParser<OneFrameMessage> _parser = new pb::MessageParser<OneFrameMessage>(() => (OneFrameMessage)MessagePool.Instance.Fetch(typeof(OneFrameMessage)));
    public static pb::MessageParser<OneFrameMessage> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private int op_;
    public int Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    private pb::ByteString aMessage_ = pb::ByteString.Empty;
    public pb::ByteString AMessage {
      get { return aMessage_; }
      set {
        aMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Op != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Op);
      }
      if (AMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(AMessage);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(232, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Op);
      }
      if (AMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(AMessage);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      op_ = 0;
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Op = input.ReadInt32();
            break;
          }
          case 18: {
            AMessage = input.ReadBytes();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 744: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public partial class FrameMessage : pb::IMessage {
    private static readonly pb::MessageParser<FrameMessage> _parser = new pb::MessageParser<FrameMessage>(() => (FrameMessage)MessagePool.Instance.Fetch(typeof(FrameMessage)));
    public static pb::MessageParser<FrameMessage> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private int frame_;
    public int Frame {
      get { return frame_; }
      set {
        frame_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::ETModel.OneFrameMessage> _repeated_message_codec
        = pb::FieldCodec.ForMessage(18, global::ETModel.OneFrameMessage.Parser);
    private pbc::RepeatedField<global::ETModel.OneFrameMessage> message_ = new pbc::RepeatedField<global::ETModel.OneFrameMessage>();
    public pbc::RepeatedField<global::ETModel.OneFrameMessage> Message {
      get { return message_; }
      set { message_ = value; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Frame != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Frame);
      }
      message_.WriteTo(output, _repeated_message_codec);
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(232, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Frame != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Frame);
      }
      size += message_.CalculateSize(_repeated_message_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      frame_ = 0;
      for (int i = 0; i < message_.Count; i++) { MessagePool.Instance.Recycle(message_[i]); }
      message_.Clear();
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Frame = input.ReadInt32();
            break;
          }
          case 18: {
            message_.AddEntriesFrom(input, _repeated_message_codec);
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 744: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code