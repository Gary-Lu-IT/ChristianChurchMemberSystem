using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class users
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public string role { get; set; } = null!;

    public int? member_id { get; set; }

    public string loginid { get; set; } = null!;

    public virtual ICollection<login_logs> login_logs { get; set; } = new List<login_logs>();

    public virtual members? member { get; set; }
}
