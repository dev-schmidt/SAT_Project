using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    //internal class Court_Violates
    //{
    //}

    //Dependency Inversion - High level classes should not depend
    //on low level classes. Both should depend on abstraction.

    //Abstraction shouldn't depend on details, but rather the
    //details should depend on abstraction.

    //Example: Creating classes for Trial and Defense

    //public class Defense
    //{
    //    public void PresentCase()
    //    {
    //        //Code to defend the accused
    //    }
    //}

    //public class Trial
    //{
    //    private Defense _defense;

    //    public Trial()
    //    {
    //        _defense = new Defense();
    //    }

    //    public void OpeningStatement()
    //    {
    //        _defense.PresentCase();
    //    }
    //}

    //Above, Trial depends on Defense. This works if only the Defense
    //of the case is included. But what if we want to add the Prosecution?
    //If we want to add that with the above setup, we would need to alter
    //Trial. So, we should modify Trial NOT to depend on Defense, and instead
    //depend upon abstraction. This will mean if changes are made to Defense
    //or Prosecution, we won't have to come back to modify Trial.
}
