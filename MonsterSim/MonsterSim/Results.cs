using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Results
    {
        public static void OVTWinner(int i, int j)
        {
            if (Orc.hp == 0)
            {
                Console.WriteLine("The Troll has won the battle. It lasted for {0} rounds", i);
            }
            else if (Troll.hp == 0)
                Console.WriteLine("The Orc won the battle. It lasted {0} rounds", i);
            else if (j == 0)
                Console.WriteLine("The fight has ended in a draw without a monster dying.");
        }

        public static void OVGWinner(int i, int j)
        {
            if (Orc.hp == 0)
            {
                Console.WriteLine("The Goblin has won the battle. It lasted for {0} rounds", i);
            }
            else if (Goblin.hp == 0)
                Console.WriteLine("The Orc won the battle. It lasted {0} rounds", i);
            else if (j == 0)
                Console.WriteLine("The fight has ended in a draw without a monster dying.");
        }

        public static void TVGWinner(int i, int j)
        {
            if (Troll.hp == 0)
            {
                Console.WriteLine("The Goblin has won the battle. It lasted for {0} rounds", i);
            }
            else if (Goblin.hp == 0)
                Console.WriteLine("The Troll won the battle. It lasted {0} rounds", i);
            else if (j == 0)
                Console.WriteLine("The fight has ended in a draw without a monster dying.");
        }
    }
}
