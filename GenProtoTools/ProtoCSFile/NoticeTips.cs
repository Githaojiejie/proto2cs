//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NoticeTips.proto
namespace ProtoCmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoticeTipsClientCmd")]
  public partial class NoticeTipsClientCmd : global::ProtoBuf.IExtensible
  {
    public NoticeTipsClientCmd() {}
    
    private int _tipid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tipid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int tipid
    {
      get { return _tipid; }
      set { _tipid = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _par = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"par", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> par
    {
      get { return _par; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoticeTipsListClientCmd")]
  public partial class NoticeTipsListClientCmd : global::ProtoBuf.IExtensible
  {
    public NoticeTipsListClientCmd() {}
    
    private readonly global::System.Collections.Generic.List<ProtoCmd.NoticeTipsClientCmd> _data = new global::System.Collections.Generic.List<ProtoCmd.NoticeTipsClientCmd>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoCmd.NoticeTipsClientCmd> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}