//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Workflows/DocumentWorkflowSettings.proto
// Note: requires additional types generated from: Workflows/ParticipantType.proto
// Note: requires additional types generated from: Workflows/ParticipantAction.proto
// Note: requires additional types generated from: Workflows/TitleReceiptBehavior.proto
// Note: requires additional types generated from: Workflows/OperatorConfirmationBehavior.proto
// Note: requires additional types generated from: Workflows/OperatorConfirmationReceiptBehavior.proto
// Note: requires additional types generated from: Workflows/ReceiptOperatorConfirmationReceiptBehavior.proto
// Note: requires additional types generated from: Workflows/AmendmentRequestResponseBehavior.proto
// Note: requires additional types generated from: Workflows/InvitationBehavior.proto
// Note: requires additional types generated from: Workflows/RoamingConfirmationBehavior.proto
namespace Diadoc.Api.Proto.Workflows
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentWorkflowSettingsList")]
  public partial class DocumentWorkflowSettingsList : global::ProtoBuf.IExtensible
  {
    public DocumentWorkflowSettingsList() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.DocumentWorkflowSettings> _DocumentWorkflowSettings = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.DocumentWorkflowSettings>();
    [global::ProtoBuf.ProtoMember(1, Name=@"DocumentWorkflowSettings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.DocumentWorkflowSettings> DocumentWorkflowSettings
    {
      get { return _DocumentWorkflowSettings; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentWorkflowSettings")]
  public partial class DocumentWorkflowSettings : global::ProtoBuf.IExtensible
  {
    public DocumentWorkflowSettings() {}
    
    private int _Id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.ParticipantSetting> _Participants = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.ParticipantSetting>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Participants", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Workflows.ParticipantSetting> Participants
    {
      get { return _Participants; }
    }
  

    private Diadoc.Api.Proto.Workflows.OperatorConfirmationReceiptBehavior.OperatorConfirmationReceiptBehavior _OperatorConfirmationReceiptBehavior = Diadoc.Api.Proto.Workflows.OperatorConfirmationReceiptBehavior.OperatorConfirmationReceiptBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OperatorConfirmationReceiptBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.OperatorConfirmationReceiptBehavior.OperatorConfirmationReceiptBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.OperatorConfirmationReceiptBehavior.OperatorConfirmationReceiptBehavior OperatorConfirmationReceiptBehavior
    {
      get { return _OperatorConfirmationReceiptBehavior; }
      set { _OperatorConfirmationReceiptBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.ReceiptOperatorConfirmationReceiptBehavior.ReceiptOperatorConfirmationReceiptBehavior _ReceiptOperatorConfirmationReceiptBehavior = Diadoc.Api.Proto.Workflows.ReceiptOperatorConfirmationReceiptBehavior.ReceiptOperatorConfirmationReceiptBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ReceiptOperatorConfirmationReceiptBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.ReceiptOperatorConfirmationReceiptBehavior.ReceiptOperatorConfirmationReceiptBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.ReceiptOperatorConfirmationReceiptBehavior.ReceiptOperatorConfirmationReceiptBehavior ReceiptOperatorConfirmationReceiptBehavior
    {
      get { return _ReceiptOperatorConfirmationReceiptBehavior; }
      set { _ReceiptOperatorConfirmationReceiptBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior _ReceiptOperatorConfirmationBehavior = Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReceiptOperatorConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior ReceiptOperatorConfirmationBehavior
    {
      get { return _ReceiptOperatorConfirmationBehavior; }
      set { _ReceiptOperatorConfirmationBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.AmendmentRequestResponseBehavior.AmendmentRequestResponseBehavior _AmendmentRequestResponseBehavior = Diadoc.Api.Proto.Workflows.AmendmentRequestResponseBehavior.AmendmentRequestResponseBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AmendmentRequestResponseBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.AmendmentRequestResponseBehavior.AmendmentRequestResponseBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.AmendmentRequestResponseBehavior.AmendmentRequestResponseBehavior AmendmentRequestResponseBehavior
    {
      get { return _AmendmentRequestResponseBehavior; }
      set { _AmendmentRequestResponseBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior _AmendmentRequestOperatorConfirmationBehavior = Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"AmendmentRequestOperatorConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior AmendmentRequestOperatorConfirmationBehavior
    {
      get { return _AmendmentRequestOperatorConfirmationBehavior; }
      set { _AmendmentRequestOperatorConfirmationBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior _ReceiptRoamingConfirmationBehavior = Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ReceiptRoamingConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior ReceiptRoamingConfirmationBehavior
    {
      get { return _ReceiptRoamingConfirmationBehavior; }
      set { _ReceiptRoamingConfirmationBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior _AmendmentRequestRoamingConfirmationBehavior = Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"AmendmentRequestRoamingConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior AmendmentRequestRoamingConfirmationBehavior
    {
      get { return _AmendmentRequestRoamingConfirmationBehavior; }
      set { _AmendmentRequestRoamingConfirmationBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.InvitationBehavior.InvitationBehavior _InvitationBehavior = Diadoc.Api.Proto.Workflows.InvitationBehavior.InvitationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"InvitationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.InvitationBehavior.InvitationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.InvitationBehavior.InvitationBehavior InvitationBehavior
    {
      get { return _InvitationBehavior; }
      set { _InvitationBehavior = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParticipantSetting")]
  public partial class ParticipantSetting : global::ProtoBuf.IExtensible
  {
    public ParticipantSetting() {}
    

    private Diadoc.Api.Proto.Workflows.ParticipantType.ParticipantType _Participant = Diadoc.Api.Proto.Workflows.ParticipantType.ParticipantType.Unknown;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Participant", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.ParticipantType.ParticipantType.Unknown)]
    public Diadoc.Api.Proto.Workflows.ParticipantType.ParticipantType Participant
    {
      get { return _Participant; }
      set { _Participant = value; }
    }

    private Diadoc.Api.Proto.Workflows.ParticipantAction.ParticipantAction _ParticipantAction = Diadoc.Api.Proto.Workflows.ParticipantAction.ParticipantAction.Unknown;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ParticipantAction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.ParticipantAction.ParticipantAction.Unknown)]
    public Diadoc.Api.Proto.Workflows.ParticipantAction.ParticipantAction ParticipantAction
    {
      get { return _ParticipantAction; }
      set { _ParticipantAction = value; }
    }

    private Diadoc.Api.Proto.Workflows.TitleReceiptBehavior.TitleReceiptBehavior _TitleReceiptBehavior = Diadoc.Api.Proto.Workflows.TitleReceiptBehavior.TitleReceiptBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TitleReceiptBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.TitleReceiptBehavior.TitleReceiptBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.TitleReceiptBehavior.TitleReceiptBehavior TitleReceiptBehavior
    {
      get { return _TitleReceiptBehavior; }
      set { _TitleReceiptBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior _OperatorConfirmationBehavior = Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OperatorConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.OperatorConfirmationBehavior.OperatorConfirmationBehavior OperatorConfirmationBehavior
    {
      get { return _OperatorConfirmationBehavior; }
      set { _OperatorConfirmationBehavior = value; }
    }

    private Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior _RoamingConfirmationBehavior = Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RoamingConfirmationBehavior", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior.Unknown)]
    public Diadoc.Api.Proto.Workflows.RoamingConfirmationBehavior.RoamingConfirmationBehavior RoamingConfirmationBehavior
    {
      get { return _RoamingConfirmationBehavior; }
      set { _RoamingConfirmationBehavior = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}