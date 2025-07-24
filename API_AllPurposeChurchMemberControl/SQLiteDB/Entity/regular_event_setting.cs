using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class regular_event_setting
{
    public int id { get; set; }

    public string title { get; set; } = null!;

    public string freq { get; set; } = null!;

    public string holdtime { get; set; } = null!;

    public string? location { get; set; }

    public string? leader { get; set; }
}
