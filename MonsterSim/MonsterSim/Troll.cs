using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Troll
    {
        public static string race = "Troll";
        public static float hp; //health
        public static float ap; //attackpower
        public static float dp; //defense
        public static float s;  //speed

        public static void choiceTroll()       // Troll stat input + check to see if the input is a valid number
        {
            bool isChoosingHP = true;
            bool isChoosingAP = true;
            bool isChoosingDP = true;
            bool isChoosingS = true;

            Console.WriteLine("Your choice is Troll, please tell us about it's stats:");
            while (isChoosingHP == true)
            {
                Console.WriteLine("How high is the Troll's health?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatHP))
                {
                    isChoosingHP = false;
                    Troll.hp = parsedfloatHP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingAP == true)
            {
                Console.WriteLine("How high is the Troll's attackpower?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatAP))
                {
                    isChoosingAP = false;
                    Troll.ap = parsedfloatAP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingDP == true)
            {
                Console.WriteLine("How high is the Troll's defense?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatDP))
                {
                    isChoosingDP = false;
                    Troll.dp = parsedfloatDP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingS == true)
            {
                Console.WriteLine("How fast is the Troll?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatS))
                {
                    isChoosingS = false;
                    Troll.s = parsedfloatS;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
        }
               
        public static void Attack()
        {
            int i = 0;
            int j = 100;

            switch (Program.choice2)
            {
                case 1:     // Troll vs Orc works as long as the troll has more ap than the orc dp
                    if (Compare.speed(Troll.s, Orc.s) == true)
                    {
                        Console.WriteLine("The Troll's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.TrollVsOrc();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Troll.ap, Orc.dp));
                            Console.WriteLine("After the {0}. round the Orc has {1}hp left.", i, Orc.hp);
                            Console.WriteLine(Combat.Damage(Orc.ap, Troll.dp));
                            Console.WriteLine("Meanwhile the Troll has {0}hp left.", Troll.hp);
                        }
                        while (Troll.hp > 0 && Orc.hp > 0 && j != 0);
                        Results.OVTWinner(i, j);
                    }
                    else
                    {
                        Console.WriteLine("The Orc's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.OrcVsTroll();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Orc.ap, Troll.dp));
                            Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                            Console.WriteLine(Combat.Damage(Troll.ap, Orc.dp));
                            Console.WriteLine("Meanwhile the Orc has {0}hp left.", Orc.hp);
                        }
                        while (Troll.hp > 0 && Orc.hp > 0 && j != 0);
                        Results.OVTWinner(i, j);
                    }
                    break;
                case 3:     //Troll vs Goblin works without issue
                    if (Compare.speed(Troll.s, Goblin.s) == true)
                    {
                        Console.WriteLine("The Troll's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.TrollVsGoblin();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Troll.ap, Goblin.dp));
                            Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                            Console.WriteLine(Combat.Damage(Goblin.ap, Troll.dp));
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                        }
                        while (Troll.hp > 0 && Goblin.hp > 0 && j != 0);
                        Results.TVGWinner(i, j);
                    }
                    else
                    {
                        Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.GoblinVsTroll();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Goblin.ap, Troll.dp));
                            Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                            Console.WriteLine(Combat.Damage(Troll.ap, Goblin.dp));
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                        }
                        while (Troll.hp > 0 && Goblin.hp > 0 && j != 0);
                        Results.TVGWinner(i, j);
                    }
                    break;
            }
        }
    }
}
