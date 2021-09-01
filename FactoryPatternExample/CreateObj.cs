using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
   public class CreateObj      //This is the factory where the object will be created
    {
        public static I1 getobject(string typeofobj)
        {
            I1 obj = null;
            if (typeofobj.ToLower() == "student")
            {
                obj = new Student();
            }
            else
            {
                obj = new Teacher();
            }
            return obj;
        }


    }
}
