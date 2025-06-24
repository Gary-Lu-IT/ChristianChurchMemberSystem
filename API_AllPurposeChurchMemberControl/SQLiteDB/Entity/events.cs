using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class events
{
    public int id { get; set; }

    public string title { get; set; } = null!;

    public DateTime event_date { get; set; }

    public string? location { get; set; }

    public string? leader { get; set; }

    public string? type { get; set; }

    public virtual ICollection<event_attendance> event_attendance { get; set; } = new List<event_attendance>();
}
