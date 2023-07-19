using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Adult : Person
    {
        public bool HasDriversLicense { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}. I {(HasDriversLicense ? "do" : "don't")} have my driver's license.";
        }
    }
}
