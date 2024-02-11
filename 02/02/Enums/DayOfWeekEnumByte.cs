using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Enums;

public enum DayOfWeekEnumByte:byte
{
    Saturday =0,
    Sunday=1,
    Monday=2,
    Tuesday=3,
    Wednesday=4,
    Thursday = 5,
    Friday=6,

    // Name Cannot Be Duplicate Value
    // Value Can Be Duplicate
}
