//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: worldflag.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldFlagData")]
  public partial class WorldFlagData : global::ProtoBuf.IExtensible
  {
    public WorldFlagData() {}
    
    private uint _key = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint key
    {
      get { return _key; }
      set { _key = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SyncWorldFlagCmd")]
  public partial class SyncWorldFlagCmd : global::ProtoBuf.IExtensible
  {
    public SyncWorldFlagCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.WorldFlagData> _data = new global::System.Collections.Generic.List<ProtoCmd.WorldFlagData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.WorldFlagData> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"WorldFlag")]
    public enum WorldFlag
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_CourtPoint", Value=1)]
      WorldFlag_CourtPoint = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_FightPoint", Value=2)]
      WorldFlag_FightPoint = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_SocialPoint", Value=3)]
      WorldFlag_SocialPoint = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_CharPoint", Value=4)]
      WorldFlag_CharPoint = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_StoryPoint", Value=5)]
      WorldFlag_StoryPoint = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_EquiptPoint", Value=6)]
      WorldFlag_EquiptPoint = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_GeneralPoint", Value=7)]
      WorldFlag_GeneralPoint = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_TotalPoint", Value=8)]
      WorldFlag_TotalPoint = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_Zone", Value=9)]
      WorldFlag_Zone = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery1", Value=10)]
      WorldFlag_ActivityLottery1 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery2", Value=11)]
      WorldFlag_ActivityLottery2 = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery3", Value=12)]
      WorldFlag_ActivityLottery3 = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery4", Value=13)]
      WorldFlag_ActivityLottery4 = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery5", Value=14)]
      WorldFlag_ActivityLottery5 = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_ActivityLottery6", Value=15)]
      WorldFlag_ActivityLottery6 = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_Activity", Value=16)]
      WorldFlag_Activity = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_TravelLabel", Value=17)]
      WorldFlag_TravelLabel = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_MailID", Value=18)]
      WorldFlag_MailID = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_Start", Value=101)]
      WorldFlag_button_Start = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_task", Value=102)]
      WorldFlag_button_task = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_shop", Value=103)]
      WorldFlag_button_shop = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_draw", Value=104)]
      WorldFlag_button_draw = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_bag", Value=105)]
      WorldFlag_button_bag = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_story", Value=106)]
      WorldFlag_button_story = 106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_role", Value=107)]
      WorldFlag_button_role = 107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_coolspring", Value=108)]
      WorldFlag_button_coolspring = 108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_create", Value=109)]
      WorldFlag_button_create = 109,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_order", Value=110)]
      WorldFlag_button_order = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_Decorateroom", Value=111)]
      WorldFlag_button_Decorateroom = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_mail", Value=112)]
      WorldFlag_button_mail = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_chat", Value=113)]
      WorldFlag_button_chat = 113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_friendship", Value=114)]
      WorldFlag_button_friendship = 114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_video", Value=115)]
      WorldFlag_button_video = 115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_camera", Value=116)]
      WorldFlag_button_camera = 116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_emaki", Value=117)]
      WorldFlag_button_emaki = 117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_boss", Value=118)]
      WorldFlag_button_boss = 118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_Fight", Value=119)]
      WorldFlag_button_Fight = 119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_practice", Value=120)]
      WorldFlag_button_practice = 120,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_open_boss", Value=121)]
      WorldFlag_open_boss = 121,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_open_guide", Value=122)]
      WorldFlag_open_guide = 122,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_open_travel", Value=123)]
      WorldFlag_open_travel = 123,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_open_lottery", Value=124)]
      WorldFlag_open_lottery = 124,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_DebugLogOpen", Value=125)]
      WorldFlag_DebugLogOpen = 125,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WorldFlag_button_End", Value=126)]
      WorldFlag_button_End = 126
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"LogicFlag")]
    public enum LogicFlag
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LogicFlag_sceneid", Value=1)]
      LogicFlag_sceneid = 1
    }
  
}