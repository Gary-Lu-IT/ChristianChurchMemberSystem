using System;
using System.Collections.Generic;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.ExceptionLogs;

public partial class EXCEPTIONDATA
{
    public int SERIAL { get; set; }

    public string EVENTTIME { get; set; } = null!;

    public string CALLERFUNCTION { get; set; } = null!;

    public string? PARAM { get; set; }

    public string EXMESSAGE { get; set; } = null!;

    public string EXSTACKTRACE { get; set; } = null!;
}
