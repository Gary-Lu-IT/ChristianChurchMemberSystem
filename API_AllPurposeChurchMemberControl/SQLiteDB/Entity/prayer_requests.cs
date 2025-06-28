using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class prayer_requests
{
    public int id { get; set; }

    public int member_id { get; set; }

    public string pray_Request { get; set; } = null!;

    public DateTime create_date { get; set; }

    public DateTime? modify_date { get; set; }

    public DateTime? stop_date { get; set; }

    public virtual members member { get; set; } = null!;
}
