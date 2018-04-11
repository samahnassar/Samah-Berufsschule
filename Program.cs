using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            SpielRegeln ob = new SpielRegeln();
            ob.Welcome();
            ob.DrawBoard();

            while (ob.Count <= 9)
            {

                ob.Input();
                ob.PositionTaken();
                ob.PlayerChange();
                ob.DrawBoard();

                if (ob.WinFlag == true)
                {
                    ob.SomeOneWon();
                    if (ob.Choice == 1)
                    {
                        ob.Count = 0;
                        ob.BoardReset();
                        ob.Welcome();
                        ob.DrawBoard();
                    }
                    else
                    {
                        ob.Count = 10;
                        break;
                    }
                }
                if (ob.WinFlag == false && ob.Count > 8)
                {
                    ob.NoOneWon();

                    if (ob.Choice == 1)
                    {
                        ob.Count = 0;
                        ob.BoardReset();
                        ob.Welcome();
                        ob.DrawBoard();
                    }
                    else
                    {
                        ob.Count = 10;
                        break;
                    }
                }



            }
        }



    }
}



