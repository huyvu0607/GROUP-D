using System;
using System.Collections.Generic;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class KoiAccount
{
    public int AccId { get; set; }

    public string Password { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Description { get; set; } = null!;

    public int? Role { get; set; }

    public virtual ICollection<UserMember> UserMembers { get; set; } = new List<UserMember>();
}
