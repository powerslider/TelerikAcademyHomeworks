using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}

struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class FallingRocks
{
    public static bool playGame = true;
    public static int playFieldWidth;
    public static int playFieldHeight;
    public static ConsoleKeyInfo pressedKey;
    
    public static int livesCount = 5;
    public static int score = 0;
    public static bool hit = true;
    public static int chance;
    
    public static Random randomGen = new Random();
    
    public static List<Rock> rocks = new List<Rock>();
    public static List<Rock> newRocksList = new List<Rock>();
    public static List<Rock> scoreBonuses = new List<Rock>();
    public static List<Rock> newScoreBonusList = new List<Rock>();
    public static List<Rock> liveBonuses = new List<Rock>();
    public static List<Rock> newLiveBonusList = new List<Rock>();

    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Yellow)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
   
    static void PrintOnStringPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Yellow)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 101;

        playFieldWidth = Console.WindowWidth;
        playFieldHeight = 38;

        Object dwarf = new Object();
        dwarf.x = 50;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.str = "(0)";
        dwarf.color = ConsoleColor.White;

        while (playGame)
        {
            hit = false; //Everything is moving until the dwarf is hit
            {
                ChanceCollision();

                //Controling the dwarf
                if (Console.KeyAvailable)
                {
                    DwarfControls(ref dwarf, pressedKey);
                    ClearBuffer();
                }
                
                //Setting the movement of the rocks and the bonuses
                MoveRocks(ref dwarf);
                MoveScoreBonuses(ref dwarf);
                MoveLiveBonuses(ref dwarf);
                
                //Clearing the console after each "while" iteration
                Console.Clear();

                //Printing the rocks and the bonuses on the console and 
                //with each iteration on a different position
                PrintOnConsole(ref dwarf);
      
                //Setting gameplay speed and 
                //printing "Lives:" and "Score" signs
                SpeedAndSigns();               
            }
        }
    }

    public static void ClearBuffer()
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
    }

    public static void DwarfControls(ref Object dwarf, ConsoleKeyInfo pressedKey)
    {
        pressedKey = Console.ReadKey(true);
        if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            if (pressedKey.Modifiers != ConsoleModifiers.Shift)
            {
                dwarf.x--;
            }
            else
            {
                dwarf.x = dwarf.x - 2;
            }
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            if (pressedKey.Modifiers != ConsoleModifiers.Shift)
            {
                dwarf.x++;
            }
            else
            {
                dwarf.x = dwarf.x + 2;
            }
        }
    }
    
    public static void ChanceCollision()
    {
        int chance = randomGen.Next(0, 100);
        if (chance <= 25)
        {
            Rock scoreBonus = new Rock();
            scoreBonus.color = ConsoleColor.Magenta;
            scoreBonus.c = '\u0002';
            scoreBonus.x = randomGen.Next(0, playFieldWidth);
            scoreBonus.y = 3;
            scoreBonuses.Add(scoreBonus);
        }
        if (chance < 5)
        {
            Rock liveBonus = new Rock();
            liveBonus.color = ConsoleColor.Green;
            liveBonus.c = '?';
            liveBonus.x = randomGen.Next(0, playFieldWidth);
            liveBonus.y = 3;
            liveBonuses.Add(liveBonus);
        }
        if (chance < 15)
        {
            Rock rockOne = new Rock();
            rockOne.x = randomGen.Next(0, playFieldWidth);
            rockOne.y = 3;
            rockOne.c = '@';
            rockOne.color = ConsoleColor.Cyan;
            rocks.Add(rockOne);

            Rock rockTwo = new Rock();
            rockTwo.x = randomGen.Next(0, playFieldWidth);
            rockTwo.y = 3;
            rockTwo.c = '^';
            rockTwo.color = ConsoleColor.Blue;
            rocks.Add(rockTwo);

            Rock rockThree = new Rock();
            rockThree.x = randomGen.Next(0, playFieldWidth);
            rockThree.y = 3;
            rockThree.c = '*';
            rockThree.color = ConsoleColor.Yellow;
            rocks.Add(rockThree);

            Rock rockFour = new Rock();
            rockFour.x = randomGen.Next(0, playFieldWidth);
            rockFour.y = 3;
            rockFour.c = '&';
            rockFour.color = ConsoleColor.DarkYellow;
            rocks.Add(rockFour);

            Rock rockFive = new Rock();
            rockFive.x = randomGen.Next(0, playFieldWidth);
            rockFive.y = 3;
            rockFive.c = '+';
            rockFive.color = ConsoleColor.Yellow;
            rocks.Add(rockFive);

            Rock rockSix = new Rock();
            rockSix.x = randomGen.Next(0, playFieldWidth);
            rockSix.y = 3;
            rockSix.c = '%';
            rockSix.color = ConsoleColor.DarkCyan;
            rocks.Add(rockSix);

            Rock rockSeven = new Rock();
            rockSeven.x = randomGen.Next(0, playFieldWidth);
            rockSeven.y = 3;
            rockSeven.c = '$';
            rockSeven.color = ConsoleColor.DarkGreen;
            rocks.Add(rockSeven);

            Rock rockEight = new Rock();
            rockEight.x = randomGen.Next(0, playFieldWidth);
            rockEight.y = 3;
            rockEight.c = '#';
            rockEight.color = ConsoleColor.Gray;
            rocks.Add(rockEight);

            Rock rockNine = new Rock();
            rockNine.x = randomGen.Next(0, playFieldWidth);
            rockNine.y = 3;
            rockNine.c = '!';
            rockNine.color = ConsoleColor.White;
            rocks.Add(rockNine);

            Rock rockTen = new Rock();
            rockTen.x = randomGen.Next(0, playFieldWidth);
            rockTen.y = 3;
            rockTen.c = '.';
            rockTen.color = ConsoleColor.DarkYellow;
            rocks.Add(rockTen);

            Rock rockEleven = new Rock();
            rockEleven.x = randomGen.Next(0, playFieldWidth);
            rockEleven.y = 3;
            rockEleven.c = ';';
            rockEleven.color = ConsoleColor.DarkBlue;
            rocks.Add(rockEleven);
        }
    }
    
    public static void MoveRocks(ref Object dwarf)
    {
        newRocksList = new List<Rock>();
        for (int i = 0; i < rocks.Count; i++)
        {
            Rock oldRocks = rocks[i];
            Rock newRocks = new Rock();
            newRocks.x = oldRocks.x;
            newRocks.y = oldRocks.y + 1;
            newRocks.c = oldRocks.c;
            newRocks.color = oldRocks.color;

            if ((dwarf.x == newRocks.x || (dwarf.x + 1) == newRocks.x || dwarf.x + 2 == newRocks.x) &&
                (dwarf.y == newRocks.y || (dwarf.y + 1) == newRocks.y || dwarf.y + 2 == newRocks.y))
            {
                livesCount--;
                rocks.Clear();
                scoreBonuses.Clear();
                liveBonuses.Clear();
                PrintOnStringPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
                Console.Beep();
                if (livesCount <= 0)
                {
                    Console.Clear();
                    PrintOnStringPosition(47, 20, "GAME OVER", ConsoleColor.Red);
                    PrintOnStringPosition(43, 23, "You're score is: " + score, ConsoleColor.Yellow);
                    PrintOnStringPosition(42, 30, "Press [enter] to exit", ConsoleColor.White);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else if (newRocks.y < Console.WindowHeight - 1)
            {
                newRocksList.Add(newRocks);
            }
        }
        rocks = newRocksList;
    }
    
    public static void MoveScoreBonuses(ref Object dwarf)
    {
        newScoreBonusList = new List<Rock>();
        for (int i = 0; i < scoreBonuses.Count; i++)
        {
            Rock oldScoreBonuses = scoreBonuses[i];
            Rock newScoreBonuses = new Rock();
            newScoreBonuses.x = oldScoreBonuses.x;
            newScoreBonuses.y = oldScoreBonuses.y + 1;
            newScoreBonuses.c = oldScoreBonuses.c;
            newScoreBonuses.color = oldScoreBonuses.color;

            if ((dwarf.x == newScoreBonuses.x || (dwarf.x + 1) == newScoreBonuses.x || dwarf.x + 2 == newScoreBonuses.x) &&
            (dwarf.y == newScoreBonuses.y || (dwarf.y + 1) == newScoreBonuses.y || dwarf.y + 2 == newScoreBonuses.y))
            {
                score++;
                Console.Beep(1000, 20);
            }
            else if (newScoreBonuses.y < Console.WindowHeight - 1)
            {
                newScoreBonusList.Add(newScoreBonuses);
            }
        }
        scoreBonuses = newScoreBonusList;
    }
    
    public static void MoveLiveBonuses(ref Object dwarf)
    {
        newLiveBonusList = new List<Rock>();
        for (int i = 0; i < liveBonuses.Count; i++)
        {
            Rock oldLiveBonuses = liveBonuses[i];
            Rock newLiveBonuses = new Rock();
            newLiveBonuses.x = oldLiveBonuses.x;
            newLiveBonuses.y = oldLiveBonuses.y + 1;
            newLiveBonuses.c = oldLiveBonuses.c;
            newLiveBonuses.color = oldLiveBonuses.color;

            if ((dwarf.x == newLiveBonuses.x || (dwarf.x + 1) == newLiveBonuses.x || dwarf.x + 2 == newLiveBonuses.x) &&
                (dwarf.y == newLiveBonuses.y || (dwarf.y + 1) == newLiveBonuses.y || dwarf.y + 2 == newLiveBonuses.y))
            {
                livesCount++;
                Console.Beep(1000, 20);
            }
            else if (newLiveBonuses.y < Console.WindowHeight - 1)
            {
                newLiveBonusList.Add(newLiveBonuses);
            }
        }
        liveBonuses = newLiveBonusList;
    }

    public static void PrintOnConsole(ref Object dwarf)
    {
        PrintOnStringPosition(dwarf.x, dwarf.y, dwarf.str, dwarf.color);
        foreach (Rock newRocks in rocks)
        {
            PrintOnPosition(newRocks.x, newRocks.y + 1, newRocks.c, newRocks.color);
        }
        foreach (Rock newScoreBonuses in scoreBonuses)
        {
            PrintOnPosition(newScoreBonuses.x, newScoreBonuses.y + 1, newScoreBonuses.c, newScoreBonuses.color);
        }
        foreach (Rock newLiveBonuses in liveBonuses)
        {
            PrintOnPosition(newLiveBonuses.x, newLiveBonuses.y + 1, newLiveBonuses.c, newLiveBonuses.color);
        }
    }
    
    public static void SpeedAndSigns()
    {
        PrintOnStringPosition(1, 1, "Lives: " + livesCount);
        PrintOnStringPosition(1, 2, "Score: " + score);
        Thread.Sleep(150);
    }
}