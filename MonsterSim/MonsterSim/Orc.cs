using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Orc
    {        
        public static string race = "Orc";
        public static float hp; //healthj
        public static float ap; //attackpower
        public static float dp; //defense
        public static float s;  //speed

        public static void choiceOrc()       // Orc stat input + check to see if the input is a valid number
        {
            bool isChoosingHP = true;
            bool isChoosingAP = true;
            bool isChoosingDP = true;
            bool isChoosingS = true;

            while (isChoosingHP == true)
            {
                Console.WriteLine("How high is the Orc's health?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatHP))
                {
                    isChoosingHP = false;
                    Orc.hp = parsedfloatHP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingAP == true)
            {
                Console.WriteLine("How high is the Orc's attackpower?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatAP))
                {
                    isChoosingAP = false;
                    Orc.ap = parsedfloatAP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingDP == true)
            {
                Console.WriteLine("How high is the Orc's defense?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatDP))
                {
                    isChoosingDP = false;
                    Orc.dp = parsedfloatDP;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again.");
                }
            }
            while (isChoosingS == true)
            {
                Console.WriteLine("How fast is the Orc?");
                if (float.TryParse(Console.ReadLine(), out float parsedfloatS))
                {
                    isChoosingS = false;
                    Orc.s = parsedfloatS;
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
                case 2:     // Orc vs Troll does not work - dmg calculation always returns 0
                    if (Compare.speed(Orc.s, Troll.s) == true)
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
                        while (Orc.hp > 0 && Troll.hp > 0 && j != 0);
                        Results.OVTWinner(i, j);
                    }
                    else
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
                        while (Orc.hp > 0 && Troll.hp > 0 && j != 0);
                        Results.OVTWinner(i, j);
                    }
                    break;
                case 3:
                    if (Compare.speed(Orc.s, Goblin.s) == true)
                    {
                        Console.WriteLine("The Orc's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.OrcVsGoblin();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Orc.ap, Goblin.dp));
                            Console.WriteLine("After the {0}. round the Goblin has {1}hp left.", i, Goblin.hp);
                            Console.WriteLine(Combat.Damage(Goblin.ap, Orc.dp));
                            Console.WriteLine("Meanwhile the Orc has {0}hp left.", Orc.hp);
                        }
                        while (Orc.hp > 0 && Goblin.hp > 0 && j != 0);
                        Results.OVGWinner(i, j);
                    }
                    else
                    {
                        Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                        do
                        {
                            Combat.GoblinVsOrc();
                            i++;
                            j--;
                            Console.WriteLine(Combat.Damage(Goblin.ap, Orc.dp));
                            Console.WriteLine("After the {0}. round the Orc has {1}hp left.", i, Orc.hp);
                            Console.WriteLine(Combat.Damage(Orc.ap, Goblin.dp));
                            Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                        }
                        while (Orc.hp > 0 && Goblin.hp > 0 && j != 0);
                        Results.OVGWinner(i, j);
                    }
                    break;
            }
        }
    }
}
