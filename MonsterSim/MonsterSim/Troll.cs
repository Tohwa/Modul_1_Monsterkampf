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
        public static float result;

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

        public static float attack(float choice2)
        {
            switch (Program.choice2)
            {
                case 1:
                    result = ap - Orc.dp;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    break;
                case 3:
                    result = ap - Goblin.dp;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    break;
            }
            return result;
        }
    }
}
