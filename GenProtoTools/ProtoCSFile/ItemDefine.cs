//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemDefine.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemLocation")]
  public partial class ItemLocation : global::ProtoBuf.IExtensible
  {
    public ItemLocation() {}
    
    private int _x = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _z = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }
    private int _charid = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemBase")]
  public partial class ItemBase : global::ProtoBuf.IExtensible
  {
    public ItemBase() {}
    
    private uint _thisid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _baseid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"baseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint baseid
    {
      get { return _baseid; }
      set { _baseid = value; }
    }
    private uint _num = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private ulong _createid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"createid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong createid
    {
      get { return _createid; }
      set { _createid = value; }
    }
    private ulong _charid = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private ulong _cardid = default(ulong);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"cardid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong cardid
    {
      get { return _cardid; }
      set { _cardid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemAttrPair")]
  public partial class ItemAttrPair : global::ProtoBuf.IExtensible
  {
    public ItemAttrPair() {}
    
    private uint _status = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _value_min = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"value_min", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint value_min
    {
      get { return _value_min; }
      set { _value_min = value; }
    }
    private uint _value_max = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"value_max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint value_max
    {
      get { return _value_max; }
      set { _value_max = value; }
    }
    private uint _parm = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"parm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint parm
    {
      get { return _parm; }
      set { _parm = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemAttrData")]
  public partial class ItemAttrData : global::ProtoBuf.IExtensible
  {
    public ItemAttrData() {}
    
    private int _num = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.ItemAttrPair> _attr_pair = new global::System.Collections.Generic.List<ProtoCmd.ItemAttrPair>();
    [global::ProtoBuf.ProtoMember(3, Name=@"attr_pair", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.ItemAttrPair> attr_pair
    {
      get { return _attr_pair; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemEquipAttrData")]
  public partial class ItemEquipAttrData : global::ProtoBuf.IExtensible
  {
    public ItemEquipAttrData() {}
    
    private int _num = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.ItemAttrData> _attr_data = new global::System.Collections.Generic.List<ProtoCmd.ItemAttrData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"attr_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.ItemAttrData> attr_data
    {
      get { return _attr_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipRandAttrData")]
  public partial class EquipRandAttrData : global::ProtoBuf.IExtensible
  {
    public EquipRandAttrData() {}
    
    private int _attr = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"attr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int attr
    {
      get { return _attr; }
      set { _attr = value; }
    }
    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private uint _val = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint val
    {
      get { return _val; }
      set { _val = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemCommAttrData")]
  public partial class ItemCommAttrData : global::ProtoBuf.IExtensible
  {
    public ItemCommAttrData() {}
    
    private bool _islock = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"islock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool islock
    {
      get { return _islock; }
      set { _islock = value; }
    }
    private uint _strength_lv = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"strength_lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint strength_lv
    {
      get { return _strength_lv; }
      set { _strength_lv = value; }
    }
    private uint _strength_value = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"strength_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint strength_value
    {
      get { return _strength_value; }
      set { _strength_value = value; }
    }
    private uint _rarity = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rarity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rarity
    {
      get { return _rarity; }
      set { _rarity = value; }
    }
    private uint _star = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint star
    {
      get { return _star; }
      set { _star = value; }
    }
    private uint _max_star = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"max_star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint max_star
    {
      get { return _max_star; }
      set { _max_star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemSerialize")]
  public partial class ItemSerialize : global::ProtoBuf.IExtensible
  {
    public ItemSerialize() {}
    
    private ProtoCmd.ItemBase _base_data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"base_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.ItemBase base_data
    {
      get { return _base_data; }
      set { _base_data = value; }
    }
    private ProtoCmd.ItemCommAttrData _comm_attr = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"comm_attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.ItemCommAttrData comm_attr
    {
      get { return _comm_attr; }
      set { _comm_attr = value; }
    }
    private ProtoCmd.ItemEquipAttrData _equip_attr = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"equip_attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.ItemEquipAttrData equip_attr
    {
      get { return _equip_attr; }
      set { _equip_attr = value; }
    }
    private uint _strengthen_luck = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"strengthen_luck", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint strengthen_luck
    {
      get { return _strengthen_luck; }
      set { _strengthen_luck = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipAttrData")]
  public partial class EquipAttrData : global::ProtoBuf.IExtensible
  {
    public EquipAttrData() {}
    
    private uint _attr_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"attr_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint attr_type
    {
      get { return _attr_type; }
      set { _attr_type = value; }
    }
    private uint _attr_value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"attr_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint attr_value
    {
      get { return _attr_value; }
      set { _attr_value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipAttrbute")]
  public partial class EquipAttrbute : global::ProtoBuf.IExtensible
  {
    public EquipAttrbute() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.EquipAttrData> _data = new global::System.Collections.Generic.List<ProtoCmd.EquipAttrData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.EquipAttrData> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemNumPair")]
  public partial class ItemNumPair : global::ProtoBuf.IExtensible
  {
    public ItemNumPair() {}
    
    private uint _drop_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"drop_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint drop_type
    {
      get { return _drop_type; }
      set { _drop_type = value; }
    }
    private uint _this_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"this_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint this_id
    {
      get { return _this_id; }
      set { _this_id = value; }
    }
    private uint _item_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint item_id
    {
      get { return _item_id; }
      set { _item_id = value; }
    }
    private uint _item_num = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"item_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint item_num
    {
      get { return _item_num; }
      set { _item_num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"AwardType")]
    public enum AwardType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AwardType_Base", Value=0)]
      AwardType_Base = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AwardType_Extra", Value=1)]
      AwardType_Extra = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ItemGeneType")]
    public enum ItemGeneType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_None", Value=0)]
      ItemGeneType_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Equip", Value=1)]
      ItemGeneType_Equip = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Fashion", Value=2)]
      ItemGeneType_Fashion = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Common", Value=3)]
      ItemGeneType_Common = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Material", Value=4)]
      ItemGeneType_Material = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Money", Value=5)]
      ItemGeneType_Money = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_RandEquip", Value=6)]
      ItemGeneType_RandEquip = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Furniture", Value=7)]
      ItemGeneType_Furniture = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Data", Value=8)]
      ItemGeneType_Data = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Character", Value=9)]
      ItemGeneType_Character = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_HeadFrameGift", Value=10)]
      ItemGeneType_HeadFrameGift = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_BackYard", Value=11)]
      ItemGeneType_BackYard = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemGeneType_Max", Value=11)]
      ItemGeneType_Max = 11
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ItemSubType_Equip")]
    public enum ItemSubType_Equip
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Begin", Value=0)]
      ItemSubType_Equip_Begin = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_HairClasp", Value=1)]
      ItemSubType_Equip_HairClasp = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Necklace", Value=2)]
      ItemSubType_Equip_Necklace = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Bracelet", Value=3)]
      ItemSubType_Equip_Bracelet = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Ring", Value=4)]
      ItemSubType_Equip_Ring = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Belt", Value=5)]
      ItemSubType_Equip_Belt = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Ornament", Value=6)]
      ItemSubType_Equip_Ornament = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Hat", Value=7)]
      ItemSubType_Equip_Hat = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Clothes", Value=8)]
      ItemSubType_Equip_Clothes = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Weapon1", Value=9)]
      ItemSubType_Equip_Weapon1 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Weapon2", Value=10)]
      ItemSubType_Equip_Weapon2 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Face", Value=11)]
      ItemSubType_Equip_Face = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_Suit", Value=12)]
      ItemSubType_Equip_Suit = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Equip_End", Value=13)]
      ItemSubType_Equip_End = 13
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ItemSubType_Common")]
    public enum ItemSubType_Common
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Common_Common", Value=1)]
      ItemSubType_Common_Common = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Common_Chip", Value=2)]
      ItemSubType_Common_Chip = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Common_Exp", Value=3)]
      ItemSubType_Common_Exp = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Common_Quest", Value=4)]
      ItemSubType_Common_Quest = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemSubType_Common_Gift", Value=5)]
      ItemSubType_Common_Gift = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipPostion")]
    public enum EquipPostion
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Begin", Value=0)]
      EquipPosition_Begin = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_HairClasp", Value=1)]
      EquipPosition_HairClasp = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Necklace", Value=2)]
      EquipPosition_Necklace = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Bracelet", Value=3)]
      EquipPosition_Bracelet = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Ring", Value=4)]
      EquipPosition_Ring = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Belt", Value=5)]
      EquipPosition_Belt = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Ornament", Value=6)]
      EquipPosition_Ornament = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Hat", Value=7)]
      EquipPosition_Hat = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Clothes", Value=8)]
      EquipPosition_Clothes = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Weapon1", Value=9)]
      EquipPosition_Weapon1 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Weapon2", Value=10)]
      EquipPosition_Weapon2 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Face", Value=11)]
      EquipPosition_Face = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_Suit", Value=12)]
      EquipPosition_Suit = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipPosition_End", Value=13)]
      EquipPosition_End = 13
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"PackageType")]
    public enum PackageType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_None", Value=0)]
      PackageType_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_CommonEquip", Value=1)]
      PackageType_CommonEquip = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_Material", Value=2)]
      PackageType_Material = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_Common", Value=3)]
      PackageType_Common = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_Equip", Value=5)]
      PackageType_Equip = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_Fashion", Value=6)]
      PackageType_Fashion = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_CommonFurniture", Value=7)]
      PackageType_CommonFurniture = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PackageType_Furniture", Value=8)]
      PackageType_Furniture = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipAttrGeneType")]
    public enum EquipAttrGeneType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipAttrGeneType_Base", Value=0)]
      EquipAttrGeneType_Base = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipAttrGeneType_Additional", Value=1)]
      EquipAttrGeneType_Additional = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ItemOperationType")]
    public enum ItemOperationType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_None", Value=0)]
      ItemOperationType_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Remove", Value=1)]
      ItemOperationType_Remove = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Move", Value=2)]
      ItemOperationType_Move = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Swap", Value=3)]
      ItemOperationType_Swap = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Split", Value=4)]
      ItemOperationType_Split = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Union", Value=5)]
      ItemOperationType_Union = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Use", Value=6)]
      ItemOperationType_Use = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Sell", Value=7)]
      ItemOperationType_Sell = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_BatchSell", Value=8)]
      ItemOperationType_BatchSell = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_Use2Npc", Value=9)]
      ItemOperationType_Use2Npc = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_EquipForm", Value=10)]
      ItemOperationType_EquipForm = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ItemOperationType_UnionMove", Value=11)]
      ItemOperationType_UnionMove = 11
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipImproveOpType")]
    public enum EquipImproveOpType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_None", Value=0)]
      EquipImproveOpType_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Reform", Value=1)]
      EquipImproveOpType_Reform = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Strengthen", Value=2)]
      EquipImproveOpType_Strengthen = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_UpStar", Value=3)]
      EquipImproveOpType_UpStar = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Decompose", Value=4)]
      EquipImproveOpType_Decompose = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_ReformComfirm", Value=5)]
      EquipImproveOpType_ReformComfirm = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Lock", Value=6)]
      EquipImproveOpType_Lock = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Sell", Value=7)]
      EquipImproveOpType_Sell = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_FurnitureCompose", Value=8)]
      EquipImproveOpType_FurnitureCompose = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_Compose", Value=9)]
      EquipImproveOpType_Compose = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EquipImproveOpType_OpenGift", Value=10)]
      EquipImproveOpType_OpenGift = 10
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"AddItemAction")]
    public enum AddItemAction
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_None", Value=0)]
      AddItemAction_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Treasure", Value=1)]
      AddItemAction_Treasure = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Activity", Value=2)]
      AddItemAction_Activity = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADDItemAction_MonsterLost", Value=3)]
      ADDItemAction_MonsterLost = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_GMAdd", Value=4)]
      AddItemAction_GMAdd = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_LoadCommonPack", Value=5)]
      AddItemAction_LoadCommonPack = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Move", Value=6)]
      AddItemAction_Move = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Union", Value=7)]
      AddItemAction_Union = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_PickFromMail", Value=8)]
      AddItemAction_PickFromMail = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Lottery", Value=9)]
      AddItemAction_Lottery = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_InitChar", Value=10)]
      AddItemAction_InitChar = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Cultivate", Value=11)]
      AddItemAction_Cultivate = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Quest", Value=12)]
      AddItemAction_Quest = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Login", Value=13)]
      AddItemAction_Login = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_EquipDecompose", Value=14)]
      AddItemAction_EquipDecompose = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_EquipReform", Value=15)]
      AddItemAction_EquipReform = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_EquipStrengthen", Value=16)]
      AddItemAction_EquipStrengthen = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_EquipLock", Value=17)]
      AddItemAction_EquipLock = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Travel", Value=18)]
      AddItemAction_Travel = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Mall", Value=19)]
      AddItemAction_Mall = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_InitPlayer", Value=20)]
      AddItemAction_InitPlayer = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_FurnitureCompose", Value=21)]
      AddItemAction_FurnitureCompose = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_MonthCardAward", Value=22)]
      AddItemAction_MonthCardAward = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Fb", Value=23)]
      AddItemAction_Fb = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddItemAction_Max", Value=60)]
      AddItemAction_Max = 60
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DelItemAction")]
    public enum DelItemAction
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_None", Value=200)]
      DelItemAction_None = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_GmCmd", Value=201)]
      DelItemAction_GmCmd = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_UseItem", Value=202)]
      DelItemAction_UseItem = 202,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Uinon", Value=203)]
      DelItemAction_Uinon = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Quest", Value=204)]
      DelItemAction_Quest = 204,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Move", Value=205)]
      DelItemAction_Move = 205,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Lottery", Value=206)]
      DelItemAction_Lottery = 206,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_TimeUpDestroy", Value=207)]
      DelItemAction_TimeUpDestroy = 207,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Cultivate", Value=208)]
      DelItemAction_Cultivate = 208,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_EquipStrengthen", Value=209)]
      DelItemAction_EquipStrengthen = 209,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_EquipDecompose", Value=210)]
      DelItemAction_EquipDecompose = 210,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Sell", Value=211)]
      DelItemAction_Sell = 211,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_CharRankUp", Value=212)]
      DelItemAction_CharRankUp = 212,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_EquipReform", Value=213)]
      DelItemAction_EquipReform = 213,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Travel", Value=214)]
      DelItemAction_Travel = 214,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_FurnitureCompose", Value=215)]
      DelItemAction_FurnitureCompose = 215,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_RoleLink", Value=216)]
      DelItemAction_RoleLink = 216,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Refine", Value=217)]
      DelItemAction_Refine = 217,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DelItemAction_Max", Value=217)]
      DelItemAction_Max = 217
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DropType")]
    public enum DropType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"DropType_Base", Value=1)]
      DropType_Base = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DropType_Hide_Ach", Value=2)]
      DropType_Hide_Ach = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DropType_First_Clear", Value=3)]
      DropType_First_Clear = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DropType_Extra", Value=4)]
      DropType_Extra = 4
    }
  
}