using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Compare
    {
        public static bool race()        // check to see if both choosen monster have the same race
        {
            if (Program.choice2.Equals(Program.choice1))
            {
                Console.Clear();
                Console.WriteLine("Two monster of the same race are not allowed to battle each other!");
                return true;
            }
            else
                return false;
        }

        public static bool speed(float spd1, float spd2)     //speedcheck to see which monster is allowed to attack first
        {
            if (spd1 >= spd2)
            {
                return true;
            }
            else
                return false;
        }
    }
}
