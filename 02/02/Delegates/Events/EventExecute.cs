using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _02._02.Delegates.Events.EventArguments;
using _02._02.Delegates.Events.Models.Teachers;

namespace _02._02.Delegates.Events;

public class EventExecute
{
    public void Execute()
    {
        Teacher objNewTeacher = new Teacher(1, "pouya");
        objNewTeacher.TeacherNameChanged += Logger;

        objNewTeacher.ChangeName("alireza");
        objNewTeacher.ChangeName("pedram");
        objNewTeacher.ChangeName("milad");
        ;
    }

    public void Logger(object sender, TeacherEnentsArgs args)
    {
        Console.WriteLine($"Old Name : {args.OldName} -- New Name: {args.NewName}");
    }
}
