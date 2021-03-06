//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SkillCommand.proto
// Note: requires additional types generated from: ErrorCode.proto
// Note: requires additional types generated from: SkillDefine.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshSkillLearnTimeClientCmd")]
  public partial class RefreshSkillLearnTimeClientCmd : global::ProtoBuf.IExtensible
  {
    public RefreshSkillLearnTimeClientCmd() {}
    
    private uint _remain_time = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"remain_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint remain_time
    {
      get { return _remain_time; }
      set { _remain_time = value; }
    }
    private int _limit_time = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"limit_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int limit_time
    {
      get { return _limit_time; }
      set { _limit_time = value; }
    }
    private uint _learn_state = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"learn_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint learn_state
    {
      get { return _learn_state; }
      set { _learn_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillBase")]
  public partial class SkillBase : global::ProtoBuf.IExtensible
  {
    public SkillBase() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillInfo")]
  public partial class SkillInfo : global::ProtoBuf.IExtensible
  {
    public SkillInfo() {}
    
    private ProtoCmd.SkillBase _base = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"base", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.SkillBase @base
    {
      get { return _base; }
      set { _base = value; }
    }
    private uint _grid_index = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"grid_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint grid_index
    {
      get { return _grid_index; }
      set { _grid_index = value; }
    }
    private bool _is_usable = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_usable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_usable
    {
      get { return _is_usable; }
      set { _is_usable = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateSkillClientCmd")]
  public partial class UpdateSkillClientCmd : global::ProtoBuf.IExtensible
  {
    public UpdateSkillClientCmd() {}
    
    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private ProtoCmd.SkillInfo _skill;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public ProtoCmd.SkillInfo skill
    {
      get { return _skill; }
      set { _skill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RefreshSkillSkillClientCmd")]
  public partial class RefreshSkillSkillClientCmd : global::ProtoBuf.IExtensible
  {
    public RefreshSkillSkillClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.SkillInfo> _skills = new global::System.Collections.Generic.List<ProtoCmd.SkillInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.SkillInfo> skills
    {
      get { return _skills; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddSkillClientCmd")]
  public partial class AddSkillClientCmd : global::ProtoBuf.IExtensible
  {
    public AddSkillClientCmd() {}
    
    private ProtoCmd.SkillInfo _skill;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public ProtoCmd.SkillInfo skill
    {
      get { return _skill; }
      set { _skill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveSkillClientCmd")]
  public partial class RemoveSkillClientCmd : global::ProtoBuf.IExtensible
  {
    public RemoveSkillClientCmd() {}
    
    private uint _skill_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestSkillLevelUpClientCmd")]
  public partial class RequestSkillLevelUpClientCmd : global::ProtoBuf.IExtensible
  {
    public RequestSkillLevelUpClientCmd() {}
    
    private uint _char_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"char_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint char_id
    {
      get { return _char_id; }
      set { _char_id = value; }
    }
    private uint _skill_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspSkillLevelUpClientCmd")]
  public partial class RspSkillLevelUpClientCmd : global::ProtoBuf.IExtensible
  {
    public RspSkillLevelUpClientCmd() {}
    
    private uint _char_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"char_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint char_id
    {
      get { return _char_id; }
      set { _char_id = value; }
    }
    private uint _skill_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private uint _skill_lev = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"skill_lev", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_lev
    {
      get { return _skill_lev; }
      set { _skill_lev = value; }
    }
    private uint _rst = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rst", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestSwapSkillClientCmd")]
  public partial class RequestSwapSkillClientCmd : global::ProtoBuf.IExtensible
  {
    public RequestSwapSkillClientCmd() {}
    
    private uint _char_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"char_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint char_id
    {
      get { return _char_id; }
      set { _char_id = value; }
    }
    private uint _skill_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private uint _grid_index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"grid_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint grid_index
    {
      get { return _grid_index; }
      set { _grid_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}