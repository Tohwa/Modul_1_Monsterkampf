using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Goblin
    {
        public static string race = "Goblin";
        public static float hp; //health
        public static float ap; //attackpower
        public static float dp; //defense
        public static float s;  //speed
        public static float result;

        public static void choiceGoblin()      // Goblin stat input + check to see if the input is a valid number
        {
            bool isChoosingHP = true;
            bool isChoosingAP = true;
            bool isChoosingDP = true;
            bool isChoosingS = true;

            Console.WriteLine("Your choice is Goblin, please tell us about it's stats:");
            while (isChoosingHP == true)
            {
                Console.WriteLine("How high is the Goblin's health?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatHP))
                {
                    isChoosingHP = false;
                    Goblin.hp = parsedfloatHP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingAP == true)
            {
                Console.WriteLine("How high is the Goblin's attackpower?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatAP))
                {
                    isChoosingAP = false;
                    Goblin.ap = parsedfloatAP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingDP == true)
            {
                Console.WriteLine("How high is the Goblin's defense?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatDP))
                {
                    isChoosingDP = false;
                    Goblin.dp = parsedfloatDP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingS == true)
            {
                Console.WriteLine("How fast is the Goblin?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatS))
                {
                    isChoosingS = false;
                    Goblin.s = parsedfloatS;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            return;

        }
    
        public static void Attack()
        {
            int i;
            int j;

            switch (Program.choice2)
            {
                case 1:     // Combat is not initialized no clue why
                    if (Compare.speed(Goblin.s, Orc.s) == true)
                    {
                        Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.GoblinVsOrc();
                            i++;
                            j--;
                            Console.WriteLine("After the {0}. round the Orc has {1}hp left.", i, Orc.hp);
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                            // Console.WriteLine(Goblin.result);
                            // Console.WriteLine(Orc.result);
                        }
                        while (Goblin.hp > 0 && Orc.hp > 0 && j != 0);
                        Results.OVGWinner(i, j);
                    }
                    else
                    {
                        Console.WriteLine("The Orc's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.OrcVsGoblin();
                            i++;
                            j--;
                            Console.WriteLine("After the {0}. round the Goblin has {1}hp left.", i, Goblin.hp);
                            Console.WriteLine("Meanwhile the Orc has {0}hp left.", Orc.hp);
                            // Console.WriteLine(Goblin.result);
                            // Console.WriteLine(Orc.result);
                        }
                        while (Goblin.hp > 0 && Orc.hp > 0 && j != 0);
                        Results.OVGWinner(i, j);
                    }
                    break;
                case 2:
                    if (Compare.speed(Goblin.s, Troll.s) == true)
                    {
                        Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.GoblinVsTroll();
                            i++;
                            j--;
                            Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                            Console.WriteLine(Goblin.result);
                            Console.WriteLine(Troll.result);
                        }
                        while (Goblin.hp > 0 && Troll.hp > 0 && j != 0);
                        Results.TVGWinner(i, j);
                    }
                    else
                    {
                        Console.WriteLine("The Troll's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.TrollVsGoblin();
                            i++;
                            j--;
                            Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                            Console.WriteLine(Goblin.result);
                            Console.WriteLine(Troll.result);
                        }
                        while (Goblin.hp > 0 && Troll.hp > 0 && j != 0);
                        Results.TVGWinner(i, j);
                    }
                    break;
            }
        }
    }
}
