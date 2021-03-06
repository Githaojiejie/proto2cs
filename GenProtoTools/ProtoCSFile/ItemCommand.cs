//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemCommand.proto
// Note: requires additional types generated from: ItemDefine.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddItemListItemClientCmd")]
  public partial class AddItemListItemClientCmd : global::ProtoBuf.IExtensible
  {
    public AddItemListItemClientCmd() {}
    
    private int _action = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int action
    {
      get { return _action; }
      set { _action = value; }
    }
    private int _item_num = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"item_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int item_num
    {
      get { return _item_num; }
      set { _item_num = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.ItemSerialize> _data = new global::System.Collections.Generic.List<ProtoCmd.ItemSerialize>();
    [global::ProtoBuf.ProtoMember(3, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.ItemSerialize> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddDataItemClientCmd")]
  public partial class AddDataItemClientCmd : global::ProtoBuf.IExtensible
  {
    public AddDataItemClientCmd() {}
    
    private int _action = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int action
    {
      get { return _action; }
      set { _action = value; }
    }
    private ProtoCmd.ItemSerialize _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.ItemSerialize data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveDataItemClientCmd")]
  public partial class RemoveDataItemClientCmd : global::ProtoBuf.IExtensible
  {
    public RemoveDataItemClientCmd() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private int _action = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int action
    {
      get { return _action; }
      set { _action = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SplitItemClientCmd")]
  public partial class SplitItemClientCmd : global::ProtoBuf.IExtensible
  {
    public SplitItemClientCmd() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnionItemClientCmd")]
  public partial class UnionItemClientCmd : global::ProtoBuf.IExtensible
  {
    public UnionItemClientCmd() {}
    
    private uint _src_thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"src_thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint src_thisid
    {
      get { return _src_thisid; }
      set { _src_thisid = value; }
    }
    private uint _dst_thisid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dst_thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dst_thisid
    {
      get { return _dst_thisid; }
      set { _dst_thisid = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshCountItemClientCmd")]
  public partial class RefreshCountItemClientCmd : global::ProtoBuf.IExtensible
  {
    public RefreshCountItemClientCmd() {}
    
    private bool _is_add = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_add", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_add
    {
      get { return _is_add; }
      set { _is_add = value; }
    }
    private uint _action = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint action
    {
      get { return _action; }
      set { _action = value; }
    }
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private uint _use_time = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"use_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint use_time
    {
      get { return _use_time; }
      set { _use_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshLocationItemClientCmd")]
  public partial class RefreshLocationItemClientCmd : global::ProtoBuf.IExtensible
  {
    public RefreshLocationItemClientCmd() {}
    
    private uint _action = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint action
    {
      get { return _action; }
      set { _action = value; }
    }
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _src_charid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"src_charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint src_charid
    {
      get { return _src_charid; }
      set { _src_charid = value; }
    }
    private uint _dst_charid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"dst_charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dst_charid
    {
      get { return _dst_charid; }
      set { _dst_charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UseItemClientCmd")]
  public partial class UseItemClientCmd : global::ProtoBuf.IExtensible
  {
    public UseItemClientCmd() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MoveItemClientCmd")]
  public partial class MoveItemClientCmd : global::ProtoBuf.IExtensible
  {
    public MoveItemClientCmd() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnionMoveItemClientCmd")]
  public partial class UnionMoveItemClientCmd : global::ProtoBuf.IExtensible
  {
    public UnionMoveItemClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<uint> _thisid = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> thisid
    {
      get { return _thisid; }
    }
  
    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseItemOperationItemClientCmd")]
  public partial class ResponseItemOperationItemClientCmd : global::ProtoBuf.IExtensible
  {
    public ResponseItemOperationItemClientCmd() {}
    
    private int _ret = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private int _op_type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"op_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int op_type
    {
      get { return _op_type; }
      set { _op_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UseItemToNpcClientCmd")]
  public partial class UseItemToNpcClientCmd : global::ProtoBuf.IExtensible
  {
    public UseItemToNpcClientCmd() {}
    
    private uint _this_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"this_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint this_id
    {
      get { return _this_id; }
      set { _this_id = value; }
    }
    private uint _npc_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"npc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint npc_id
    {
      get { return _npc_id; }
      set { _npc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SellItemClientCmd")]
  public partial class SellItemClientCmd : global::ProtoBuf.IExtensible
  {
    public SellItemClientCmd() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BatchSellItemClientCmd")]
  public partial class BatchSellItemClientCmd : global::ProtoBuf.IExtensible
  {
    public BatchSellItemClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<uint> _thisid = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> thisid
    {
      get { return _thisid; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildStorOperItemClientCmd")]
  public partial class GuildStorOperItemClientCmd : global::ProtoBuf.IExtensible
  {
    public GuildStorOperItemClientCmd() {}
    
    private ProtoCmd.GuildStorOperItemClientCmd.Type _type = ProtoCmd.GuildStorOperItemClientCmd.Type.Close;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ProtoCmd.GuildStorOperItemClientCmd.Type.Close)]
    public ProtoCmd.GuildStorOperItemClientCmd.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Close", Value=0)]
      Close = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Open", Value=1)]
      Open = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FreshGuildStorItemClientCmd")]
  public partial class FreshGuildStorItemClientCmd : global::ProtoBuf.IExtensible
  {
    public FreshGuildStorItemClientCmd() {}
    
    private uint _cap = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cap
    {
      get { return _cap; }
      set { _cap = value; }
    }
    private bool _append = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"append", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool append
    {
      get { return _append; }
      set { _append = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.ItemSerialize> _data = new global::System.Collections.Generic.List<ProtoCmd.ItemSerialize>();
    [global::ProtoBuf.ProtoMember(3, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.ItemSerialize> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSuitAttr")]
  public partial class EquipSuitAttr : global::ProtoBuf.IExtensible
  {
    public EquipSuitAttr() {}
    
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshEquipSuitAttrClientCmd")]
  public partial class RefreshEquipSuitAttrClientCmd : global::ProtoBuf.IExtensible
  {
    public RefreshEquipSuitAttrClientCmd() {}
    
    private uint _suit_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"suit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint suit_id
    {
      get { return _suit_id; }
      set { _suit_id = value; }
    }
    private readonly global::System.Collections.Generic.List<bool> _equip_pos = new global::System.Collections.Generic.List<bool>();
    [global::ProtoBuf.ProtoMember(2, Name=@"equip_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<bool> equip_pos
    {
      get { return _equip_pos; }
    }
  
    private uint _collect_num = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"collect_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint collect_num
    {
      get { return _collect_num; }
      set { _collect_num = value; }
    }
    private uint _link_num = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"link_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint link_num
    {
      get { return _link_num; }
      set { _link_num = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.EquipSuitAttr> _suit_attr = new global::System.Collections.Generic.List<ProtoCmd.EquipSuitAttr>();
    [global::ProtoBuf.ProtoMember(5, Name=@"suit_attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.EquipSuitAttr> suit_attr
    {
      get { return _suit_attr; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipImproveClientCmd")]
  public partial class EquipImproveClientCmd : global::ProtoBuf.IExtensible
  {
    public EquipImproveClientCmd() {}
    
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _this_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"this_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint this_id
    {
      get { return _this_id; }
      set { _this_id = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _cost_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"cost_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> cost_id
    {
      get { return _cost_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspEquipImproveClientCmd")]
  public partial class RspEquipImproveClientCmd : global::ProtoBuf.IExtensible
  {
    public RspEquipImproveClientCmd() {}
    
    private uint _action = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint action
    {
      get { return _action; }
      set { _action = value; }
    }
    private uint _rst = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rst", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rst
    {
      get { return _rst; }
      set { _rst = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqBuyFashionClientCmd")]
  public partial class ReqBuyFashionClientCmd : global::ProtoBuf.IExtensible
  {
    public ReqBuyFashionClientCmd() {}
    
    private uint _item_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint item_id
    {
      get { return _item_id; }
      set { _item_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspBuyFashionClientCmd")]
  public partial class RspBuyFashionClientCmd : global::ProtoBuf.IExtensible
  {
    public RspBuyFashionClientCmd() {}
    
    private uint _rst = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rst", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rst
    {
      get { return _rst; }
      set { _rst = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FurnitureInfo")]
  public partial class FurnitureInfo : global::ProtoBuf.IExtensible
  {
    public FurnitureInfo() {}
    
    private uint _this_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"this_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint this_id
    {
      get { return _this_id; }
      set { _this_id = value; }
    }
    private ProtoCmd.ItemLocation _dst = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dst", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.ItemLocation dst
    {
      get { return _dst; }
      set { _dst = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MoveFurnitureClientCmd")]
  public partial class MoveFurnitureClientCmd : global::ProtoBuf.IExtensible
  {
    public MoveFurnitureClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.FurnitureInfo> _data = new global::System.Collections.Generic.List<ProtoCmd.FurnitureInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.FurnitureInfo> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspMoveFurnitureClientCmd")]
  public partial class RspMoveFurnitureClientCmd : global::ProtoBuf.IExtensible
  {
    public RspMoveFurnitureClientCmd() {}
    
    private uint _ret = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspGetInfoClientCmd")]
  public partial class RspGetInfoClientCmd : global::ProtoBuf.IExtensible
  {
    public RspGetInfoClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.ItemNumPair> _data = new global::System.Collections.Generic.List<ProtoCmd.ItemNumPair>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.ItemNumPair> data
    {
      get { return _data; }
    }
  
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}