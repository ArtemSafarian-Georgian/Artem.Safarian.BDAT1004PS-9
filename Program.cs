using System;

namespace Problem_set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            object o  = 5;
        Console.WriteLine(o.GetType());
      
        object V1  = 5.0;
        Console.WriteLine(V1.GetType());

         object V2  = 5>1;
        Console.WriteLine(V2.GetType());

        
         object V3  = '5';
        Console.WriteLine(V3.GetType());

        
         object V4  = 5*2;
        Console.WriteLine(V4.GetType());

        object V5  = 5/2;
        Console.WriteLine(V5.GetType());

        object V6  = 5%2;
        Console.WriteLine(V6.GetType());

       

         object V8  = 5==3;
        Console.WriteLine(V8.GetType());

        object V9  = (Math.PI);
        Console.WriteLine(V9.GetType());

        Console.WriteLine("{5,2,1} is an Invalid type ");

        }
    }
}
