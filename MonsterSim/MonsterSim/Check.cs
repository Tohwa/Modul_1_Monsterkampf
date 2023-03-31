using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Check
    {
        public static void race1()        // first racecheck
        {
            bool racecheck = false;
            do
            {
                Console.WriteLine("Please choose the monster to fight in the arena.");
                Console.WriteLine("The avaiable monster are Orc = 1, Troll = 2 and Goblin = 3.");
                Program.choice1 = Convert.ToSingle(Console.ReadLine());

                switch (Program.choice1)
                {
                    case 1:
                        Orc.choiceOrc();
                        racecheck = true;
                        break;
                    case 2:
                        Troll.choiceTroll();
                        racecheck = true;
                        break;
                    case 3:
                        Goblin.choiceGoblin();
                        racecheck = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input.");
                        break;
                }
            } while (racecheck == false);
            return;       //gibt 0 aus, warum?
        }

        public static void race2()        // second racecheck
        {
            bool racecheck = false;
            do
            {
                //Console.Clear();
                Console.WriteLine("Please choose another monster.");
                Console.WriteLine("The avaiable monster are Orc = 1, Troll = 2 and Goblin = 3.");
                Program.choice2 = Convert.ToSingle(Console.ReadLine());

                switch (Program.choice2)
                {
                    case 1:
                        Orc.choiceOrc();
                        racecheck = true;
                        break;
                    case 2:
                        ;
                        Troll.choiceTroll();
                        racecheck = true;
                        break;
                    case 3:
                        Goblin.choiceGoblin();
                        racecheck = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input. Please choose one of the before mentioned races.");
                        break;
                }
            } while (racecheck == false);
            return;
        }
    }
}
