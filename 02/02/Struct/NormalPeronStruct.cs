using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Struct;

public struct NormalPeronStruct
{
    #region Ctors
    public NormalPeronStruct()
    {
    }

    public NormalPeronStruct(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    #endregion

    #region Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    #endregion


}
