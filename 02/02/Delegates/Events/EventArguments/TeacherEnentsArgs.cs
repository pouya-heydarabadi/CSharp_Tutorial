using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Delegates.Events.EventArguments;

public class TeacherEnentsArgs:EventArgs
{
    public string OldName { get; set; }
    public string NewName { get; set; }

    public TeacherEnentsArgs(string oldName, string newName)
    {
        this.OldName = oldName;
        this.NewName = newName;
    }
}
