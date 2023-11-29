using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ActionMethods : Variables
    {
        public static void InitializeBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = boardEmptyPlace;
                }
            }
        }
        public static void ShowBoard()
        {

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j]);
                }
            }
            Console.WriteLine("\n");

        }

        public static void InputPlayerCoordinateX()
        {
            if (SwitchPlayerTurns == true)
            {
                Console.WriteLine(player1turn);
            }
            else
            {
                Console.WriteLine(player2turn);
            }
            Console.WriteLine(enterCoordinateX);
            if (!Int32.TryParse(Console.ReadLine(), out var coordinateInputX))
            {
                Console.WriteLine("Error, Try again: ");
                InputPlayerCoordinateX();
            }
            coordinateX = coordinateInputX;
            InputPlayerCoordinateY();

        }
        public static void InputPlayerCoordinateY()
        {
            Console.WriteLine(enterCoordinateY);
            if (!Int32.TryParse(Console.ReadLine(), out var coordinateInputY))
            {
                Console.WriteLine("Error, Try again: ");
                InputPlayerCoordinateY();
            }
            coordinateY = coordinateInputY;
            IfMoVeIsValidMakeMove();
        }

        public static void MakeMove()
        {

            if (SwitchPlayerTurns == true)
            {
                Board[coordinateX, coordinateY] = player1sign;
                SwitchPlayerTurns = false;
                ShowBoard();
            }
            else
            {
                Board[coordinateX, coordinateY] = player2sign;
                SwitchPlayerTurns = true;
                ShowBoard();
            }
        }

        public static void IfMoVeIsValidMakeMove()
        {
            if (coordinateX >= 0 && coordinateX < 3 && coordinateY >= 0m && coordinateY < 3 && Board[coordinateX, coordinateY] == boardEmptyPlace)
            {
                MakeMove();
            }
            else
            {
                Console.WriteLine("Error, Try again:");
            }

        }

    }
}
