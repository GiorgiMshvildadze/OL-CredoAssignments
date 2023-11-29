using System.Net.NetworkInformation;

namespace TicTacToe;

class Program : ActionMethods
{
    static void Main(string[] args)
    {
        int count = 0;
        InitializeBoard();
        ShowBoard();
        while (count < 10)
        {
            InputPlayerCoordinateX();

            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2] && Board[0, 1] != boardEmptyPlace ||
                Board[1, 0] == Board[1, 1] && Board[1, 1] == Board[1, 2] && Board[1, 1] != boardEmptyPlace ||
                Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2] && Board[2, 1] != boardEmptyPlace ||
                Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0] && Board[0, 0] != boardEmptyPlace ||
                Board[0, 1] == Board[1, 1] && Board[1, 1] == Board[2, 1] && Board[0, 1] != boardEmptyPlace ||
                Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2] && Board[0, 2] != boardEmptyPlace ||
                Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && Board[0, 0] != boardEmptyPlace ||
                Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && Board[0, 2] != boardEmptyPlace
                ) break;
            count++;
        }
    }
}
