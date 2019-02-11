﻿
[ContentType(DisplayName = "Aktivitet - mall", GUID = "769f5efe-0dd0-41f7-92f1-4b36dae3e1ba",
Description = "Definiera en aktivitet för ett arbetsflöde.", GroupName = GroupNames.Workflow)]
public class ActivityTemplate : PageData
{
    [BackingType(typeof(PropertyLongString))]
    [Display(GroupName = SystemTabNames.Content, Order = 1)]
    [Editable(false)]
    public virtual string ActivityName { get; set; }

    [BackingType(typeof(PropertyNumber))]
    [Display(Order = 2)]
    [Enum(typeof(Enums.AssignedActivityRole))]
    [UIHint("EnumProperty")]
    public virtual Enums.AssignedActivityRole AssignedRole { get; set; }

    [BackingType(typeof(PropertyNumber))]
    [Display(Order = 4, World = "My world")]
    [Enum(typeof(Enums.ActivityType))]
    [UIHint("EnumProperty")]
    public virtual Enums.ActivityType ActivityType { get; set; }

    [BackingType(typeof(PropertyNumber))]
    [Display(Order = 5)]
    [Enum(typeof(Enums.ActivitySignOffType))]
    [UIHint("EnumProperty")]
    public virtual Enums.ActivitySignOffType ActivitySignOffType { get; set; }

    [Display(GroupName = SystemTabNames.Content, Order = 7)]
    public virtual int DurationInDays { get; set; }

    [Display(GroupName = SystemTabNames.Content, Order = 8)]
    [UIHint("MailTemplate")]
    public virtual ContentArea MailTemplate { get; set; }

    [Display(GroupName = SystemTabNames.Content, Order = 9)]
    [AllowedTypes(new[] { typeof(ActivityOptionsBlock) })]
    public virtual ContentArea ActivityOptions { get; set; }

    [Display()]
    [AllowedTypes(new[] { typeof(ActivityOptionsBlock) })]
    public virtual ContentArea2 ActivityOptions { get; set; }

    public override void SetDefaultValues(ContentType contentType)
    {
        base.SetDefaultValues(contentType);
        this.AssignedRole = Enums.AssignedActivityRole.Default;
        this.ActivitySignOffType = Enums.ActivitySignOffType.Approve;
    }
}