//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GameCommand.proto
// Note: requires additional types generated from: LoginDefine.proto
// Note: requires additional types generated from: FbDefine.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqSetAttrCmd")]
  public partial class ReqSetAttrCmd : global::ProtoBuf.IExtensible
  {
    public ReqSetAttrCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.AttrInfo> _attrs = new global::System.Collections.Generic.List<ProtoCmd.AttrInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"attrs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.AttrInfo> attrs
    {
      get { return _attrs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspSetAttrCmd")]
  public partial class RspSetAttrCmd : global::ProtoBuf.IExtensible
  {
    public RspSetAttrCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.AttrInfo> _attrs = new global::System.Collections.Generic.List<ProtoCmd.AttrInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"attrs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.AttrInfo> attrs
    {
      get { return _attrs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqGetAttrCmd")]
  public partial class ReqGetAttrCmd : global::ProtoBuf.IExtensible
  {
    public ReqGetAttrCmd() {}
    
    private readonly global::System.Collections.Generic.List<uint> _keys = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> keys
    {
      get { return _keys; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspGetAttrCmd")]
  public partial class RspGetAttrCmd : global::ProtoBuf.IExtensible
  {
    public RspGetAttrCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.AttrInfo> _attrs = new global::System.Collections.Generic.List<ProtoCmd.AttrInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"attrs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.AttrInfo> attrs
    {
      get { return _attrs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspErrorCmd")]
  public partial class RspErrorCmd : global::ProtoBuf.IExtensible
  {
    public RspErrorCmd() {}
    
    private uint _error;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint error
    {
      get { return _error; }
      set { _error = value; }
    }
    private uint _levelid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"levelid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint levelid
    {
      get { return _levelid; }
      set { _levelid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqClearPVAICdCmd")]
  public partial class ReqClearPVAICdCmd : global::ProtoBuf.IExtensible
  {
    public ReqClearPVAICdCmd() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqVipRightsBuyCmd")]
  public partial class ReqVipRightsBuyCmd : global::ProtoBuf.IExtensible
  {
    public ReqVipRightsBuyCmd() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _num = (uint)1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)1)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspVipRightsBuyCmd")]
  public partial class RspVipRightsBuyCmd : global::ProtoBuf.IExtensible
  {
    public RspVipRightsBuyCmd() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyPhysicalClientCmd")]
  public partial class BuyPhysicalClientCmd : global::ProtoBuf.IExtensible
  {
    public BuyPhysicalClientCmd() {}
    
    private uint _physical = (uint)1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"physical", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)1)]
    public uint physical
    {
      get { return _physical; }
      set { _physical = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqGetPVAIFightCDCmd")]
  public partial class ReqGetPVAIFightCDCmd : global::ProtoBuf.IExtensible
  {
    public ReqGetPVAIFightCDCmd() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspGetPVAIFightCDCmd")]
  public partial class RspGetPVAIFightCDCmd : global::ProtoBuf.IExtensible
  {
    public RspGetPVAIFightCDCmd() {}
    
    private uint _remain;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"remain", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint remain
    {
      get { return _remain; }
      set { _remain = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspNotifyActivityCmd")]
  public partial class RspNotifyActivityCmd : global::ProtoBuf.IExtensible
  {
    public RspNotifyActivityCmd() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _priority = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    private byte[] _name_me = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name_me", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] name_me
    {
      get { return _name_me; }
      set { _name_me = value; }
    }
    private byte[] _name_other = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name_other", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] name_other
    {
      get { return _name_other; }
      set { _name_other = value; }
    }
    private uint _itemid = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private byte[] _item_name = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"item_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] item_name
    {
      get { return _item_name; }
      set { _item_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqSyncTime")]
  public partial class ReqSyncTime : global::ProtoBuf.IExtensible
  {
    public ReqSyncTime() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SyncTime")]
  public partial class SyncTime : global::ProtoBuf.IExtensible
  {
    public SyncTime() {}
    
    private uint _sec;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"sec", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint sec
    {
      get { return _sec; }
      set { _sec = value; }
    }
    private uint _min;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"min", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint min
    {
      get { return _min; }
      set { _min = value; }
    }
    private uint _hour;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"hour", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint hour
    {
      get { return _hour; }
      set { _hour = value; }
    }
    private uint _wday;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"wday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint wday
    {
      get { return _wday; }
      set { _wday = value; }
    }
    private uint _mday;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"mday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint mday
    {
      get { return _mday; }
      set { _mday = value; }
    }
    private uint _month;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"month", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint month
    {
      get { return _month; }
      set { _month = value; }
    }
    private uint _time = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time
    {
      get { return _time; }
      set { _time = value; }
    }
    private int _offset_utc = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"offset_utc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int offset_utc
    {
      get { return _offset_utc; }
      set { _offset_utc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}