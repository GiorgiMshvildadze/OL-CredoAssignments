using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Variables
    {
        public static string player1turn = "Player 1 turn to move, Enter Coordinates:";
        public static string player2turn = "Player 2 turn to move, Enter Coordinates";
        public static string player1sign = "X ";
        public static string player2sign = "O ";
        public static string boardEmptyPlace = "- ";
        public static string enterCoordinateX = "Enter Coordinate X (0,1,2)";
        public static string enterCoordinateY = "Enter Coordinate Y (0,1,2)";
        public static string[,] Board = new string[3, 3];
        public static bool SwitchPlayerTurns = true;
        public static int coordinateX;
        public static int coordinateY;


        
    }
}
