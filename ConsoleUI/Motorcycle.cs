using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = true;



        public override void DriveAbstract()
        {
            Console.WriteLine("this motorcycle is in drive");
        }


        public override void DriveVirtual()
        {
            Console.WriteLine($"this {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }


    }
}
