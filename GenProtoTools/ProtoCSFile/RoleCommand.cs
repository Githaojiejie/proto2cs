//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RoleCommand.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoleSkill")]
  public partial class RoleSkill : global::ProtoBuf.IExtensible
  {
    public RoleSkill() {}
    
    private uint _skill_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private uint _skill_level = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"skill_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_level
    {
      get { return _skill_level; }
      set { _skill_level = value; }
    }
    private uint _reward_state = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reward_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reward_state
    {
      get { return _reward_state; }
      set { _reward_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoleBaseData")]
  public partial class RoleBaseData : global::ProtoBuf.IExtensible
  {
    public RoleBaseData() {}
    
    private uint _roleid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint roleid
    {
      get { return _roleid; }
      set { _roleid = value; }
    }
    private uint _isinroom = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"isinroom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint isinroom
    {
      get { return _isinroom; }
      set { _isinroom = value; }
    }
    private uint _fashionid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"fashionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint fashionid
    {
      get { return _fashionid; }
      set { _fashionid = value; }
    }
    private ProtoCmd.RoleBackyardState _bystate = ProtoCmd.RoleBackyardState.eRBS_None;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"bystate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(ProtoCmd.RoleBackyardState.eRBS_None)]
    public ProtoCmd.RoleBackyardState bystate
    {
      get { return _bystate; }
      set { _bystate = value; }
    }
    private uint _backyardroomid = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"backyardroomid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint backyardroomid
    {
      get { return _backyardroomid; }
      set { _backyardroomid = value; }
    }
    private uint _skinheadid = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"skinheadid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skinheadid
    {
      get { return _skinheadid; }
      set { _skinheadid = value; }
    }
    private uint _skinbodyid = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"skinbodyid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skinbodyid
    {
      get { return _skinbodyid; }
      set { _skinbodyid = value; }
    }
    private uint _skinhandid = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"skinhandid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skinhandid
    {
      get { return _skinhandid; }
      set { _skinhandid = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.RoleSkill> _skillInfo = new global::System.Collections.Generic.List<ProtoCmd.RoleSkill>();
    [global::ProtoBuf.ProtoMember(9, Name=@"skillInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.RoleSkill> skillInfo
    {
      get { return _skillInfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoleDataClientCmd")]
  public partial class RoleDataClientCmd : global::ProtoBuf.IExtensible
  {
    public RoleDataClientCmd() {}
    
    private uint _playerid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"playerid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint playerid
    {
      get { return _playerid; }
      set { _playerid = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoCmd.RoleBaseData> _base_data = new global::System.Collections.Generic.List<ProtoCmd.RoleBaseData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"base_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.RoleBaseData> base_data
    {
      get { return _base_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SetRoleInRoomClientCmd")]
  public partial class SetRoleInRoomClientCmd : global::ProtoBuf.IExtensible
  {
    public SetRoleInRoomClientCmd() {}
    
    private uint _playerid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"playerid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint playerid
    {
      get { return _playerid; }
      set { _playerid = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _roleid = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> roleid
    {
      get { return _roleid; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqGameRoleSkinInfoClientCmd")]
  public partial class ReqGameRoleSkinInfoClientCmd : global::ProtoBuf.IExtensible
  {
    public ReqGameRoleSkinInfoClientCmd() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CurrentSkin")]
  public partial class CurrentSkin : global::ProtoBuf.IExtensible
  {
    public CurrentSkin() {}
    
    private uint _role_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }
    private uint _head_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"head_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint head_id
    {
      get { return _head_id; }
      set { _head_id = value; }
    }
    private uint _body_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"body_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint body_id
    {
      get { return _body_id; }
      set { _body_id = value; }
    }
    private uint _hand_id = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hand_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint hand_id
    {
      get { return _hand_id; }
      set { _hand_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkinInfo")]
  public partial class SkinInfo : global::ProtoBuf.IExtensible
  {
    public SkinInfo() {}
    
    private uint _skin_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skin_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skin_id
    {
      get { return _skin_id; }
      set { _skin_id = value; }
    }
    private uint _lock = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint @lock
    {
      get { return _lock; }
      set { _lock = value; }
    }
    private uint _pieces = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pieces", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pieces
    {
      get { return _pieces; }
      set { _pieces = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RspGameRoleSkinInfoClientCmd")]
  public partial class RspGameRoleSkinInfoClientCmd : global::ProtoBuf.IExtensible
  {
    public RspGameRoleSkinInfoClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.CurrentSkin> _current_skin = new global::System.Collections.Generic.List<ProtoCmd.CurrentSkin>();
    [global::ProtoBuf.ProtoMember(1, Name=@"current_skin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.CurrentSkin> current_skin
    {
      get { return _current_skin; }
    }
  
    private readonly global::System.Collections.Generic.List<ProtoCmd.SkinInfo> _skin_info = new global::System.Collections.Generic.List<ProtoCmd.SkinInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"skin_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.SkinInfo> skin_info
    {
      get { return _skin_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveCurrentSkinClientCmd")]
  public partial class SaveCurrentSkinClientCmd : global::ProtoBuf.IExtensible
  {
    public SaveCurrentSkinClientCmd() {}
    
    private ProtoCmd.CurrentSkin _current_skin = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"current_skin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.CurrentSkin current_skin
    {
      get { return _current_skin; }
      set { _current_skin = value; }
    }
    private uint _status = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqRedeemSkinClientCmd")]
  public partial class ReqRedeemSkinClientCmd : global::ProtoBuf.IExtensible
  {
    public ReqRedeemSkinClientCmd() {}
    
    private ProtoCmd.SkinInfo _skin_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skin_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoCmd.SkinInfo skin_info
    {
      get { return _skin_info; }
      set { _skin_info = value; }
    }
    private uint _status = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetRoleSkillRewardClientCmd")]
  public partial class GetRoleSkillRewardClientCmd : global::ProtoBuf.IExtensible
  {
    public GetRoleSkillRewardClientCmd() {}
    
    private uint _skill_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private uint _role_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }
    private uint _status = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoleBehaviourUnlock")]
  public partial class RoleBehaviourUnlock : global::ProtoBuf.IExtensible
  {
    public RoleBehaviourUnlock() {}
    
    private uint _role_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }
    private uint _behaviour_unlock_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"behaviour_unlock_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint behaviour_unlock_id
    {
      get { return _behaviour_unlock_id; }
      set { _behaviour_unlock_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendRoleBehaviourUnlockClientCmd")]
  public partial class SendRoleBehaviourUnlockClientCmd : global::ProtoBuf.IExtensible
  {
    public SendRoleBehaviourUnlockClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.RoleBehaviourUnlock> _role_behaviour_unlock = new global::System.Collections.Generic.List<ProtoCmd.RoleBehaviourUnlock>();
    [global::ProtoBuf.ProtoMember(1, Name=@"role_behaviour_unlock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.RoleBehaviourUnlock> role_behaviour_unlock
    {
      get { return _role_behaviour_unlock; }
    }
  
    private uint _status = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"RoleBackyardState")]
    public enum RoleBackyardState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_None", Value=0)]
      eRBS_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Plant", Value=1)]
      eRBS_Plant = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Cook", Value=2)]
      eRBS_Cook = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Taste", Value=3)]
      eRBS_Taste = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Practice", Value=4)]
      eRBS_Practice = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Travel", Value=5)]
      eRBS_Travel = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Reveal", Value=6)]
      eRBS_Reveal = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Rabbit", Value=7)]
      eRBS_Rabbit = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_Wish", Value=8)]
      eRBS_Wish = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBS_MakeFurniture", Value=9)]
      eRBS_MakeFurniture = 9
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"RoleBackyardSkillEffectType")]
    public enum RoleBackyardSkillEffectType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_None", Value=0)]
      eRBSET_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_ReduceCropGTime", Value=1)]
      eRBSET_ReduceCropGTime = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_IncreaseCropYield", Value=2)]
      eRBSET_IncreaseCropYield = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_ReduceCookExpend", Value=3)]
      eRBSET_ReduceCookExpend = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_IncreaseGetSpecialDishes", Value=4)]
      eRBSET_IncreaseGetSpecialDishes = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_GetCookExtraReward", Value=5)]
      eRBSET_GetCookExtraReward = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRBSET_IncreaseEnergyUpperLimit", Value=6)]
      eRBSET_IncreaseEnergyUpperLimit = 6
    }
  
}