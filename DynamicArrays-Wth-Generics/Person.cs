using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays_Wth_Generics
{
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public override string ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
}
