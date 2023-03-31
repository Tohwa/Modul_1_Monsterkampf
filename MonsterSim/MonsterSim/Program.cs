using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;


namespace MonsterSim
{
    internal class Program
    {
        public static float choice1;
        public static float choice2;
        
        static void Main(string[] args)
        {

            // Console.WriteLine(speedcompare(Orc.s, Troll.s));  testoutput to check speedcompare method
            Check.race1();
            //Console.WriteLine("{0}"+"{1}"+"{2}"+"{3}", Orc.hp, Orc.ap,+ Orc.dp, Orc.s); test to see if the stats are saved
            do
            {
                Check.race2();
                //Console.WriteLine(choice1);   check to see if choice1 has a value other than 0
                //Console.WriteLine(choice2);   same als prev. line
            } 
            while(Compare.race() == true);

            // complete combat checks until 1 monster is dead

            Console.Clear();
            Console.WriteLine("The fight begins");
            Console.WriteLine("Your first fighter is:");    // Output to recieve an overview of the first monster's stats
            if (choice1 == 1)
            {
                Console.WriteLine("An {0} with {1}hp, {2}ap, {3}dp and {4}s.", Orc.race, Orc.hp, Orc.ap, Orc.dp, Orc.s);
            }
            else if(choice1 == 2)
            {
                Console.WriteLine("A {0} with {1}hp, {2}ap, {3}dp and {4}s.", Troll.race, Troll.hp, Troll.ap, Troll.dp, Troll.s);
            }
            else
            {
                Console.WriteLine("A {0} with {1}hp, {2}ap, {3}dp and {4}s.", Goblin.race, Goblin.hp, Goblin.ap, Goblin.dp, Goblin.s);
            }
            
            Console.WriteLine("Your second fighter is:");   // Output to recieve an overview of the second monster's stats
            if (choice2 == 1)
            {
                Console.WriteLine("An {0} with {1}hp, {2}ap, {3}dp and {4}s.", Orc.race, Orc.hp, Orc.ap, Orc.dp, Orc.s);
            }
            else if (choice2 == 2)
            {
                Console.WriteLine("A {0} with {1}hp, {2}ap, {3}dp and {4}s.", Troll.race, Troll.hp, Troll.ap, Troll.dp, Troll.s);
            }
            else
            {
                Console.WriteLine("A {0} with {1}hp, {2}ap, {3}dp and {4}s.", Goblin.race, Goblin.hp, Goblin.ap, Goblin.dp, Goblin.s);
            }

            Combat.combatStart();                
        }                                        
    }
}