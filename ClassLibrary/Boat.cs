using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Boat
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return "Boat name is: " + Name;
        }
    }
}
