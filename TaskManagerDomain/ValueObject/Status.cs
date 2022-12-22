using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.ValueObject
{
    public enum Status
    {
        [Description("Otwarty")]
        Opened,
        [Description("Zaknięty")]
        Closed,
        [Description("W toku")]
        InProgress,
        [Description("Wycofany")]
        Revoked,
        [Description("Anulowany")]
        Cancelled,
        [Description("Otwarty ponownie")]
        Reopened
    }
}
