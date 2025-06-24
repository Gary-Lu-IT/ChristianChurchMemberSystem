using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class offerings
{
    public int id { get; set; }

    public int? member_id { get; set; }

    public DateTime offer_date { get; set; }

    public double amount { get; set; }

    public string category { get; set; } = null!;

    public string? remarks { get; set; }

    public virtual members? member { get; set; }
}
