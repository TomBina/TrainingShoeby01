using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesBackEnd2020_1
{
    public class Closure
    {
        public string Company = "Divide";

        public Action PrintName =>
            () => { Console.WriteLine(Company); };
    }
}
