using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Delegates.MultiCastDelegates;

public class MultiCastExecute
{
    public void ExecuteWithOutOutput()
    {
        SampleActions objNewSampleActions = new SampleActions();

        MultiCastDelegateSample objNewMultiCastDelegate = objNewSampleActions.CW1;
        objNewMultiCastDelegate += objNewSampleActions.CW2;
        objNewMultiCastDelegate += objNewSampleActions.CW3;
        objNewMultiCastDelegate += objNewSampleActions.CW4;
        objNewMultiCastDelegate();
    }



}
