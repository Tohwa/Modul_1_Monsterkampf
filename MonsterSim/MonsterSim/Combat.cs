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
        public static float result;

        public static float Damage(float ap, float dp, float choice2)
        {
            switch (Program.choice2)
            {
                case 1:
                    result = ap - dp;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    break;
                case 3:
                    result = ap - dp;
                    if (result < 0)
                    {
                        result = 0;
                    }
                    break;
            }
            return result;
        }

        public static void OrcVsTroll()
        {
            float dmg1 = Damage(Orc.ap, Troll.dp, Program.choice2);
            currentHealthTroll = Troll.hp - dmg1;
            Troll.hp = currentHealthTroll;
            if (Troll.hp > 0)
            {
                float dmg2 = Damage(Troll.ap, Orc.dp, Program.choice2);
                currentHealthOrc = Orc.hp - dmg2;
                Orc.hp = currentHealthOrc;
            }
        }       // Orc attacks first

        public static void OrcVsGoblin()
        {            
            float dmg1 = Damage(Orc.ap, Goblin.dp, Program.choice2);
            currentHealthGoblin = Goblin.hp - dmg1;
            Goblin.hp = currentHealthGoblin;
            if (Goblin.hp > 0)
            {
                float dmg2 = Damage(Goblin.ap, Orc.dp, Program.choice2);
                currentHealthOrc = Orc.hp - dmg2;
                Orc.hp = currentHealthOrc;
            }
        }

        public static void TrollVsGoblin()
        {
            float dmg1 = Damage(Troll.ap, Goblin.dp, Program.choice2);
            currentHealthGoblin = Goblin.hp - dmg1;
            Goblin.hp = currentHealthGoblin;
            if (Goblin.hp > 0)
            {
                float dmg2 = Damage(Goblin.ap, Troll.dp, Program.choice2);
                currentHealthTroll = Troll.hp - dmg2;
                Troll.hp = currentHealthTroll;
            }
        }   // Troll attacks first

        public static void TrollVsOrc()
        {
            float dmg1 = Damage(Troll.ap, Orc.dp, Program.choice2);
            currentHealthOrc = Orc.hp - dmg1;
            Orc.hp = currentHealthOrc;
            if (Orc.hp > 0)
            {
                float dmg2 = Damage(Orc.ap, Troll.dp, Program.choice2);
                currentHealthTroll = Troll.hp - dmg2;
                Troll.hp = currentHealthTroll;
            }
        }

        public static void GoblinVsOrc()
        {
            float dmg1 = Damage(Goblin.ap, Orc.dp, Program.choice2);
            currentHealthOrc = Orc.hp - dmg1;
            Orc.hp = currentHealthOrc;
            if (Orc.hp > 0)
            {
                float dmg2 = Damage(Orc.ap, Goblin.dp, Program.choice2);
                currentHealthGoblin = Goblin.hp - dmg2;
                Goblin.hp = currentHealthGoblin;
            }
        }           // Goblin attacks first

        public static void GoblinVsTroll()
        {
            float dmg1 = Damage(Goblin.ap, Troll.dp, Program.choice2);
            currentHealthTroll = Troll.hp - dmg1;
            Troll.hp = currentHealthTroll;
            if (Troll.hp > 0)
            {
                float dmg2 = Damage(Troll.ap, Goblin.dp, Program.choice2);
                currentHealthGoblin = Goblin.hp - dmg2;
                Goblin.hp = currentHealthGoblin;
            }
        }

        public static void combatStart()             // complete combat checks until 1 monster is dead
        {
            switch (Program.choice1) // no default case because racecheck was successful "130 & 132"
            {
                case 1:    // Orc is first choosen monster
                    Orc.Attack();                        
                    break;
                case 2:    // Troll is first choosen monster
                    Troll.Attack();
                    break;
                case 3:    // Goblin is first choosen monster
                    Goblin.Attack();
                    break;
            }            
        }
    }
}
