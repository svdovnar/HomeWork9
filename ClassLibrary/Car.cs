using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car
    {
        public string CarBrand { get; set; }
        public override string ToString()
        {
            return "Car brand is: " + CarBrand;
        }

    }
}
