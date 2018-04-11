using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToFinal
{
    class SpielRegeln
    {
        public int Choice { get; set; }
        public int Count { get; set; }
        public int Turn { get; set; }
        public bool CorrectInput { get; set; }
        public bool WinFlag { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public bool Playing { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Welcome()
        {
            Turn = 1;
            Console.WriteLine("Hallo! Das ist Tic Tac Toe.");
            Console.WriteLine("was ist der Name von Spieler 1?");
            Player1 = Console.ReadLine();
            Console.WriteLine("Sehr gut. was ist der Name von Spieler 2?");
            Player2 = Console.ReadLine();
            Console.WriteLine("Okay gut. {0} ist O und {1} ist X.", Player1, Player2);
            Console.WriteLine("{0} fängt an.", Player1);
            Console.ReadLine();
            Console.Clear();
        }
        public void DrawBoard()
        {

            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }
        public void Input()
        {

            CorrectInput = false;



            while (CorrectInput == false)
            {

                Console.WriteLine("Welche position möchtest du nehmen?");
                Choice = int.Parse(Console.ReadLine());
                Count++;

                if (Choice > 0 && Choice < 10)
                {
                    CorrectInput = true;
                }
                else
                {
                    continue;
                }
            }
            CorrectInput = false;

        }
        public bool CheckWin()
        {
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") // Horizontal ----------------------------------------
            {
                return true;
            }
            else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
            {
                return true;
            }
            else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // Diagonal -----------------------------------------
            {
                return true;
            }
            else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")// Coloumns ------------------------------------------
            {
                return true;
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
            {
                return true;
            }
            else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
            {
                return true;
            }

            if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") // Horizontal ----------------------------------------
            {
                return true;
            }
            else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
            {
                return true;
            }
            else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // Diagonal -----------------------------------------
            {
                return true;
            }
            else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // Coloumns ------------------------------------------
            {
                return true;
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
            {
                return true;
            }
            else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return true;
            }
            else // No winner ----------------------------------------------
            {
                return false;
            }
        }
        public void PositionTaken()
        {                        
            if (Turn == 1)
            {
                if (pos[Choice] == "X" || pos[Choice] == "O") // Checks to see if spot is taken already --------------------
                {
                    Console.WriteLine("Hier kannst du nicht setzen! ");
                    Console.Write("erneut versuchen.");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    pos[Choice] = "O";
                }
            }
            if (Turn == 2)
            {
                if (pos[Choice] == "O" || pos[Choice] == "X") // Checks to see if spot is taken already -------------------
                {
                    Console.WriteLine("Hier kannst du nicht setzen!  ");
                    Console.Write("erneut versuchen.");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    pos[Choice] = "X";
                }
            }
        }
        public void PlayerChange()
        {
            WinFlag = CheckWin();


            if (WinFlag == false && Count < 9)
            {
                if (Turn == 1)
                {
                    Turn = 2;
                }
                else if (Turn == 2)
                {
                    Turn = 1;
                }
                Console.Clear();
            }
        }
        public void SomeOneWon()
        {

            Score1 = 0;
            Score2 = 0;
            if (WinFlag == true) // Someone won -----------------------------
            {
                if (Turn == 1)
                {
                    Score1++;
                    Console.WriteLine("{0} gewinnt!", Player1);
                    Console.WriteLine("Was möchtest du jetzt machen?");
                    Console.WriteLine("1. erneut spielen");
                    Console.WriteLine("2. Spiel verlassen");

                    while (CorrectInput == false)
                    {
                        Console.WriteLine("Gib deine Wahl ein: ");
                        Choice = int.Parse(Console.ReadLine());

                        if (Choice > 0 && Choice < 3)
                        {
                            CorrectInput = true;
                        }
                        else { Console.WriteLine("falsche Eingabe"); }
                    }

                    CorrectInput = false; // Reset --------------

                    switch (Choice)
                    {
                        case 1:
                            Console.Clear();
                            WinFlag = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Danke fürs Spielen!");
                            Console.ReadLine();
                            Count = 10;
                            break;
                    }
                }

                if (Turn == 2)
                {
                    Score2++;
                    Console.WriteLine("{0} gewinnt!", Player2);
                    Console.WriteLine("Was möchtest du jetzt machen?");
                    Console.WriteLine("1. erneut spielen");
                    Console.WriteLine("2. Spiel verlassen");

                    while (CorrectInput == false)
                    {
                        Console.WriteLine("Gib deine Wahl ein: ");
                        Choice = int.Parse(Console.ReadLine());

                        if (Choice > 0 && Choice < 3)
                        {
                            CorrectInput = true;
                        }
                    }

                    CorrectInput = false; // Reset -----------------

                    switch (Choice)
                    {
                        case 1:
                            Console.Clear();
                            WinFlag = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Danke fürs Spielen!");
                            Console.ReadLine();
                            Count = 10;
                            break;
                    }
                }
            }
        }
        public void NoOneWon()
        {

            if (WinFlag == false) // No one won ---------------------------
            {
                Console.WriteLine("Es ist ein Gleichstand!");
                Console.WriteLine("Ergebnis: {0} - {1}     {2} - {3}", Player1, Score1, Player2, Score2);
                Console.WriteLine("");
                Console.WriteLine("Was möchtest du jetzt machen?");
                Console.WriteLine("1. erneut spielen");
                Console.WriteLine("2. Spiel verlassen");
                Console.WriteLine("");


                while (CorrectInput == false)
                {
                    Console.WriteLine("Gib deine Wahl ein: ");
                    Choice = int.Parse(Console.ReadLine());
                    if (Choice > 0 && Choice < 3)
                    {
                        CorrectInput = true;
                    }

                }

                CorrectInput = false; // Reset -------------

                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        WinFlag = false;
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("Danke fürs Spielen!");
                        Console.ReadLine();
                        Count = 10;
                        break;
                }
            }
        }
        public void BoardReset()
        {

            for (int i = 1; i < 10; i++) // Resets board ------------------------
            {
                pos[i] = i.ToString();
            }
        }

    }
}
