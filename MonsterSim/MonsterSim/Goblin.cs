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
                case 2:
                    result = ap - Troll.dp;
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
