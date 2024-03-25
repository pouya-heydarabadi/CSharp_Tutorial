using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _02._02.Delegates.Events.EventArguments;

namespace _02._02.Delegates.Events.Models.Teachers;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }

    public event EventHandler<TeacherEnentsArgs> TeacherNameChanged;

    public Teacher(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void ChangeName(string name)
    {
        TeacherEnentsArgs? args =
            new TeacherEnentsArgs
            (
                oldName: this.Name!,
                newName: name
            );
        this.Name = name;

        TeacherNameChanged(this, args);
    }
}
