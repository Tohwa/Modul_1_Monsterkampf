using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{
    internal class Combat
    {
        public static float currentHealthOrc;
        public static float currentHealthGoblin;
        public static float currentHealthTroll;

        private static void OrcVsTroll()
        {
            float dmg1 = Orc.attack(Program.choice2);
            currentHealthTroll = Troll.hp - dmg1;
            Troll.hp = currentHealthTroll;
            if (Troll.hp > 0)
            {
                float dmg2 = Troll.attack(Program.choice2);
                currentHealthOrc = Orc.hp - dmg2;
                Orc.hp = currentHealthOrc;
            }
        }       // Orc attacks first

        private static void OrcVsGoblin()
        {            
            float dmg1 = Orc.attack(Program.choice2);
            currentHealthGoblin = Goblin.hp - dmg1;
            Goblin.hp = currentHealthGoblin;
            if (Goblin.hp > 0)
            {
                float dmg2 = Goblin.attack(Program.choice2);
                currentHealthOrc = Orc.hp - dmg2;
                Orc.hp = currentHealthOrc;
            }
        }

        private static void TrollVsGoblin()
        {
            float dmg1 = Troll.attack(Program.choice2);
            currentHealthGoblin = Goblin.hp - dmg1;
            Goblin.hp = currentHealthGoblin;
            if (Goblin.hp > 0)
            {
                float dmg2 = Goblin.attack(Program.choice2);
                currentHealthTroll = Troll.hp - dmg2;
                Troll.hp = currentHealthTroll;
            }
        }   // Troll attacks first

        private static void TrollVsOrc()
        {
            float dmg1 = Troll.attack(Program.choice2);
            currentHealthOrc = Orc.hp - dmg1;
            Orc.hp = currentHealthOrc;
            if (Orc.hp > 0)
            {
                float dmg2 = Orc.attack(Program.choice2);
                currentHealthTroll = Troll.hp - dmg2;
                Troll.hp = currentHealthTroll;
            }
        }

        private static void GoblinVsOrc()
        {
            float dmg1 = Goblin.attack(Program.choice2);
            currentHealthOrc = Orc.hp - dmg1;
            Orc.hp = currentHealthOrc;
            if (Orc.hp > 0)
            {
                float dmg2 = Orc.attack(Program.choice2);
                currentHealthGoblin = Goblin.hp - dmg2;
                Goblin.hp = currentHealthGoblin;
            }
        }           // Goblin attacks first

        private static void GoblinVsTroll()
        {
            float dmg1 = Goblin.attack(Program.choice2);
            currentHealthTroll = Troll.hp - dmg1;
            Troll.hp = currentHealthTroll;
            if (Troll.hp > 0)
            {
                float dmg2 = Troll.attack(Program.choice2);
                currentHealthGoblin = Goblin.hp - dmg2;
                Goblin.hp = currentHealthGoblin;
            }
        }

        public static void combatStart()             // complete combat checks until 1 monster is dead
        {
            int i = 0;
            int j = 100;

            switch (Program.choice1) // no default case because racecheck was successful "130 & 132"
            {
                case 1:    // Orc is first choosen monster
                    switch (Program.choice2)
                    {
                        case 2:     // Orc vs Troll does not work - dmg calculation always returns 0
                            if (Compare.speed(Orc.s, Troll.s) == true)
                            {
                                Console.WriteLine("The Orc's speed is greater it will have the first móve.");
                                do
                                {
                                    OrcVsTroll();
                                    i++;
                                    j--;
                                    Console.WriteLine("After the {0}. round the Orc has {1}hp left.", i, Troll.hp);
                                    Console.WriteLine(Orc.result);
                                    Console.WriteLine("Meanwhile the Troll has {0}hp left.", Goblin.hp);
                                    Console.WriteLine(Troll.result);
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
                                    Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                                    Console.WriteLine(Troll.result);
                                    Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Orc.hp);
                                    Console.WriteLine(Orc.result);
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
                                    OrcVsGoblin();
                                    i++;
                                    j--;
                                }
                                while (Orc.hp > 0 && Goblin.hp > 0 && j != 0);
                                Results.OVGWinner(i, j);
                            }                            
                            else
                            {
                                Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                                do
                                {
                                    GoblinVsOrc();
                                    i++;
                                    j--;
                                }
                                while (Orc.hp > 0 && Goblin.hp > 0 && j != 0);
                                Results.OVGWinner(i, j);
                            }                            
                            break;
                    }
                    break;
                case 2:    // Troll is first choosen monster
                    switch (Program.choice2)
                    {
                        case 1:     // Troll vs Orc works as long as the troll has more ap than the orc dp
                            if (Compare.speed(Troll.s, Orc.s) == true)
                            {
                                Console.WriteLine("The Troll's speed is greater it will have the first móve.");
                                do
                                {
                                    TrollVsOrc();
                                    i++;
                                    j--;
                                }
                                while (Troll.hp > 0 && Orc.hp > 0 && j != 0);
                                Results.OVTWinner(i, j);
                            }
                            else
                            {
                                Console.WriteLine("The Orc's speed is greater it will have the first móve.");
                                do
                                {
                                    OrcVsTroll();
                                    i++;
                                    j--;
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
                                    TrollVsGoblin();
                                    i++;
                                    j--;
                                }
                                while (Troll.hp > 0 && Goblin.hp > 0 && j != 0);
                                Results.TVGWinner(i, j);
                            }
                            else
                            {
                                Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                                do
                                {
                                    GoblinVsTroll();
                                    i++;
                                    j--;
                                    Console.WriteLine("After the {0}. round the Troll has {1}hp left.", i, Troll.hp);
                                    Console.WriteLine("Meanwhile the Goblin has {0}hp left.", Goblin.hp);
                                    Console.WriteLine(Goblin.result);
                                    Console.WriteLine(Troll.result);
                                }
                                while (Troll.hp > 0 && Goblin.hp > 0 && j != 0);
                                Results.TVGWinner(i, j);
                            }                            
                            break;
                    }
                    break;
                case 3:    // Goblin is first choosen monster
                    switch (Program.choice2)
                    {
                        case 1:     // Combat is not initialized no clue why
                            if (Compare.speed(Goblin.s, Orc.s) == true)
                            {
                                Console.WriteLine("The Goblin's speed is greater it will have the first móve.");
                                do
                                {
                                    GoblinVsOrc();
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
                                    OrcVsGoblin();
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
                                    GoblinVsTroll();
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
                                    TrollVsGoblin();
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
                    break;
            }            
        }
    }
}
