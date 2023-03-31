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
        public static float result;

        public static void choiceOrc()         // Orc stat input + check to see if the input is a valid number
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

        public static float attack(float choice2)
        {
            switch (Program.choice2)
            {
                case 2:
                    result = ap - Troll.dp;
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
