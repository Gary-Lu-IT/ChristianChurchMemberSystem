using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class login_logs
{
    public int id { get; set; }

    public int? user_id { get; set; }

    public DateTime? login_time { get; set; }

    public string? ip_address { get; set; }

    public virtual users? user { get; set; }
}
