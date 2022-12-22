using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.ValueObject
{
    public enum Gender
    {
        [Description("Mężczyzna")]
        Male,
        [Description("Kobieta")]
        Female,
        [Description("Inne")]
        Other
    }
}
