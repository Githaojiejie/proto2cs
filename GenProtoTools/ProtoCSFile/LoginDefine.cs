//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LoginDefine.proto
namespace ProtoCmd
{
    [global::ProtoBuf.ProtoContract(Name=@"LoginReturn")]
    public enum LoginReturn
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_UNKNOWN", Value=0)]
      LOGIN_RETURN_UNKNOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_VERSIONERROR", Value=1)]
      LOGIN_RETURN_VERSIONERROR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_DBERROR", Value=2)]
      LOGIN_RETURN_DBERROR = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_NOGAMESERVER", Value=3)]
      LOGIN_RETURN_NOGAMESERVER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_PASSWORDERROR", Value=4)]
      LOGIN_RETURN_PASSWORDERROR = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_CHANGEPASSWORD", Value=5)]
      LOGIN_RETURN_CHANGEPASSWORD = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_IDINUSE", Value=6)]
      LOGIN_RETURN_IDINUSE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_IDINCLOSE", Value=7)]
      LOGIN_RETURN_IDINCLOSE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_ACCESSNOSTART", Value=8)]
      LOGIN_RETURN_ACCESSNOSTART = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_USERMAX", Value=9)]
      LOGIN_RETURN_USERMAX = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_ACCOUNTEXIST", Value=10)]
      LOGIN_RETURN_ACCOUNTEXIST = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGON_RETURN_ACCOUNTSUCCESS", Value=11)]
      LOGON_RETURN_ACCOUNTSUCCESS = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_CHARNAMEREPEAT", Value=12)]
      LOGIN_RETURN_CHARNAMEREPEAT = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_USERDATANOEXIST", Value=13)]
      LOGIN_RETURN_USERDATANOEXIST = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_USERNAMEREPEAT", Value=14)]
      LOGIN_RETURN_USERNAMEREPEAT = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_TIMEOUT", Value=15)]
      LOGIN_RETURN_TIMEOUT = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_JPEG_PASSPORT", Value=16)]
      LOGIN_RETURN_JPEG_PASSPORT = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_LOCK", Value=17)]
      LOGIN_RETURN_LOCK = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_WAITACTIVE", Value=18)]
      LOGIN_RETURN_WAITACTIVE = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_IMG_LOCK", Value=19)]
      LOGIN_RETURN_IMG_LOCK = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_DISCONNECT", Value=20)]
      LOGIN_RETURN_DISCONNECT = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_PLATFORMSUCCESS", Value=21)]
      LOGIN_RETURN_PLATFORMSUCCESS = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_RECONNECTING", Value=22)]
      LOGIN_RETURN_RECONNECTING = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_RECONNECT_OK", Value=23)]
      LOGIN_RETURN_RECONNECT_OK = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_RECONNECT_ERROR", Value=24)]
      LOGIN_RETURN_RECONNECT_ERROR = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RETURN_UNREG_LOGIN", Value=25)]
      LOGIN_RETURN_UNREG_LOGIN = 25
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ClientMachineType")]
    public enum ClientMachineType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Unknow", Value=0)]
      ClientMachineType_Unknow = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Android", Value=1)]
      ClientMachineType_Android = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Iphone", Value=2)]
      ClientMachineType_Iphone = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Ipad", Value=3)]
      ClientMachineType_Ipad = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_IosPc", Value=4)]
      ClientMachineType_IosPc = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_WinPc", Value=5)]
      ClientMachineType_WinPc = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Win8", Value=6)]
      ClientMachineType_Win8 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_WinPad", Value=7)]
      ClientMachineType_WinPad = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientMachineType_Max", Value=8)]
      ClientMachineType_Max = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ClientPlatformType")]
    public enum ClientPlatformType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_unknow", Value=0)]
      ClientPlatformType_unknow = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_weixin", Value=1)]
      ClientPlatformType_weixin = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_qq", Value=2)]
      ClientPlatformType_qq = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_oppo", Value=3)]
      ClientPlatformType_oppo = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_vivo", Value=4)]
      ClientPlatformType_vivo = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_huawei", Value=5)]
      ClientPlatformType_huawei = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_360", Value=6)]
      ClientPlatformType_360 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_xiaomi", Value=7)]
      ClientPlatformType_xiaomi = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_toutiao", Value=8)]
      ClientPlatformType_toutiao = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_weibo", Value=9)]
      ClientPlatformType_weibo = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_baidu", Value=10)]
      ClientPlatformType_baidu = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_uc", Value=11)]
      ClientPlatformType_uc = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_iqiyi", Value=12)]
      ClientPlatformType_iqiyi = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_youku", Value=13)]
      ClientPlatformType_youku = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_kuaishou", Value=14)]
      ClientPlatformType_kuaishou = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_163", Value=15)]
      ClientPlatformType_163 = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_mm", Value=16)]
      ClientPlatformType_mm = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_sogou", Value=17)]
      ClientPlatformType_sogou = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_xinpai", Value=18)]
      ClientPlatformType_xinpai = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_37", Value=19)]
      ClientPlatformType_37 = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_mianshangdian", Value=20)]
      ClientPlatformType_mianshangdian = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientPlatformType_Max", Value=100)]
      ClientPlatformType_Max = 100
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"GameType")]
    public enum GameType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GameType_MDZS", Value=3)]
      GameType_MDZS = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GameType_NEWGAME", Value=4)]
      GameType_NEWGAME = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SDKQuery")]
    public enum SDKQuery
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKQUERY_SUCC", Value=0)]
      SDKQUERY_SUCC = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKQUERY_ROLE_INVALID", Value=10)]
      SDKQUERY_ROLE_INVALID = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKQUERY_SYSTEM_INVALID", Value=100)]
      SDKQUERY_SYSTEM_INVALID = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKQUERY_PARAM_INVALID", Value=1000)]
      SDKQUERY_PARAM_INVALID = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKQUERY_ZONE_INVALID", Value=111)]
      SDKQUERY_ZONE_INVALID = 111
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SDKReward")]
    public enum SDKReward
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_SUCC", Value=1000)]
      SDKREWARD_SUCC = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_SYSTEM_INVALID", Value=1002)]
      SDKREWARD_SYSTEM_INVALID = 1002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_PARAM_INVALID", Value=1003)]
      SDKREWARD_PARAM_INVALID = 1003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_SYSTEM_MUTI_SERIANO_INVALID", Value=1006)]
      SDKREWARD_SYSTEM_MUTI_SERIANO_INVALID = 1006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_SYSTEM_ACCOUNT_INVALID", Value=1038)]
      SDKREWARD_SYSTEM_ACCOUNT_INVALID = 1038,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDKREWARD_SYSTEM_ZONE_INVALID", Value=1039)]
      SDKREWARD_SYSTEM_ZONE_INVALID = 1039
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SuspendType")]
    public enum SuspendType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SuspendType_Null", Value=0)]
      SuspendType_Null = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SuspendType_Silent", Value=1)]
      SuspendType_Silent = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SuspendType_Ban", Value=2)]
      SuspendType_Ban = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SuspendType_Danmu", Value=3)]
      SuspendType_Danmu = 3
    }
  
}