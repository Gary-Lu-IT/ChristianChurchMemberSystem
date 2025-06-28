using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class members
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string? gender { get; set; }

    public DateTime? birthdate { get; set; }

    public string? phone { get; set; }

    public string? email { get; set; }

    public string? address { get; set; }

    public bool? baptized { get; set; }

    public DateTime? baptism_date { get; set; }

    public bool? transferred { get; set; }

    public string? group_name { get; set; }

    public int? family_id { get; set; }

    public string? notes { get; set; }

    public DateTime? stopusedate { get; set; }

    public virtual ICollection<attendance> attendance { get; set; } = new List<attendance>();

    public virtual ICollection<event_attendance> event_attendance { get; set; } = new List<event_attendance>();

    public virtual ICollection<offerings> offerings { get; set; } = new List<offerings>();

    public virtual ICollection<prayer_requests> prayer_requests { get; set; } = new List<prayer_requests>();

    public virtual ICollection<users> users { get; set; } = new List<users>();
}
