using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class attendance
{
    public int id { get; set; }

    public int member_id { get; set; }

    public DateTime event_date { get; set; }

    public string event_type { get; set; } = null!;

    public string? status { get; set; }

    public string? remarks { get; set; }

    public virtual members member { get; set; } = null!;
}
