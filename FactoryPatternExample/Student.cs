using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Student : I1
    {
        public string getname()
        {
            return "Student Name";

        }
        public string getfname()
        {
            return "Student Father Name";
        }
    }
}
