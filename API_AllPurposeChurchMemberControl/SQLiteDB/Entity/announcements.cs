using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class announcements
{
    public int id { get; set; }

    public string title { get; set; } = null!;

    public string? content { get; set; }

    public DateTime? posted_at { get; set; }
}
