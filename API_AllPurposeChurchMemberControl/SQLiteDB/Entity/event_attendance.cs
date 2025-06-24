using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class event_attendance
{
    public int id { get; set; }

    public int event_id { get; set; }

    public int member_id { get; set; }

    public bool? attended { get; set; }

    public virtual events _event { get; set; } = null!;

    public virtual members member { get; set; } = null!;
}
