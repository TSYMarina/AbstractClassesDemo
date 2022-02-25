using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("Implemented Abstract Drive method for Motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Virtial Method for Motorcycle has been overridden.");
        }

    }
}
