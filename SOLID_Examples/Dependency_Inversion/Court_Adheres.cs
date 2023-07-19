using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    //internal class Court_Adheres
    //{
    //}

    public interface IAttorney
    {
        void PresentCase();
    }

    public class Defense : IAttorney
    {
        public void PresentCase()
        {
            //Code to defend the accused
        }
    }

    public class Prosecution : IAttorney
    {
        public void PresentCase()
        {
            //Code to prosecute the accused
        }
    }

    public class Trial
    {
        private IAttorney _attorney;

        public Trial(IAttorney attorney)
        {
            _attorney = attorney;
        }

        public void OpeningStatement()
        {
            _attorney.PresentCase();
        }
    }
}
