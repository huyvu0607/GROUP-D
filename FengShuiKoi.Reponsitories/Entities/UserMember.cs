using System;
using System.Collections.Generic;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class UserMember
{
    public int? Accid { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime? Birthday { get; set; }

    public string? Destiny { get; set; }

    public virtual KoiAccount? Acc { get; set; }
}
