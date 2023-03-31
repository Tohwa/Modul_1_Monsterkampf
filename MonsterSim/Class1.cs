using System;

public class Monster
{

    int maxHealthPoints;
    int currentHealthPoints;
    int attack;
    int defense;
    int speed;
    string race;

    public void fighter()
    {
        Random rnd = new Random();
        bool racecheck = false;

        Console.WriteLine($"please select a race for your first Fighter!");
        Console.WriteLine("Eingabe: ");
        race = Console.ReadLine();

        while (racecheck == false)
        {
            switch (race)
            {
                case "Orc":
                    maxHealthPoints = rnd.Next(75, 101);
                    attack = rnd.Next(50);
                    defense = rnd.Next(50);
                    speed = rnd.Next(25);
                    racecheck = true;
                    break;
                case "Troll":
                    maxHealthPoints = rnd.Next(50, 101);
                    attack = rnd.Next(35);
                    defense = rnd.Next(35);
                    speed = rnd.Next(50);
                    racecheck = true;
                    break;
                case "goblin":
                    maxHealthPoints = rnd.Next(25, 101);
                    attack = rnd.Next(25);
                    defense = rnd.Next(25);
                    speed = rnd.Next(75);
                    racecheck = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong race choosen.Please try again!");
                    racecheck = false;
                    break;
            }
        }
    }
}

