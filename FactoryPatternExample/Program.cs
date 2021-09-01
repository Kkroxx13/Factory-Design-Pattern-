using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your object type");
            string type = Console.ReadLine();
            I1 obj=CreateObj.getobject(type);
            Console.WriteLine(obj.getfname());
            Console.ReadLine();


        }
    }
     
    
    
    
    
}
