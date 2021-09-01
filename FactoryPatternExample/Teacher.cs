using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Teacher : I1
    {
        public string getname()
        {
            return "Teacher Name";

        }
        public string getfname()
        {
            return "Teacher Father Name";
        }
    }
}
