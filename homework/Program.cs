using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mashin = new Vehicle();

            mashin.color = "qara";
            mashin.year = 2019;
            

            Console.WriteLine(mashin.color);
            Console.WriteLine(mashin.year);
        }
        
        

    }
}
