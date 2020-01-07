using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesBackEnd2020_1
{
    public class Customer2 
    {
        public int CustomerId;
        public string Name;

        public override string ToString()
        {
            return $"{Name} {CustomerId}";
        }
    }
}
