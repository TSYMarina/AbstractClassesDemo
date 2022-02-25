using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("Implemented Abstract Drive method for Car.\n"); ;
        }
        public override void DriveVirtual()
        {

        }
    }
    

   

}
