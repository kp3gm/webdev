using System;

enum SquareState
{
    Undecided,
    X,
    O
}

class TicTacToe
{
    SquareState[,] board = new SquareState[3, 3];

    public TicTacToe()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = SquareState.Undecided;
            }
        }
    }

    public void Play(int x, int y, SquareState player)
    {
        if (board[x, y] != SquareState.Undecided)
        {
            Console.WriteLine("Square is already taken. Please choose another square.");
            return;
        }

        board[x, y] = player;
    }

    public SquareState CheckWinner()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 2] != SquareState.Undecided)
            {
                return board[i, 0];
            }
        }

        // Check columns
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[2, j] != SquareState.Undecided)
            {
                return board[0, j];
            }
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != SquareState.Undecided)
        {
            return board[0, 0];
        }

        if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[0, 2] != SquareState.Undecided)
        {
            return board[2, 0];
        }

        return SquareState.Undecided;
    }

    public void PrintBoard()
    {
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();

        SquareState player = SquareState.X;

        while (game.CheckWinner() == SquareState.Undecided)
        {
                            Console.WriteLine("Player " + player + ", enter your move (row column):");
            string[] move = Console.ReadLine().Split(' ');
            int x = int.Parse(move[0]) - 1;
            int y = int.Parse(move[1]) - 1;

            game.Play(x, y, player);
            game.PrintBoard();

            if (player == SquareState.X)
            {
                player = SquareState.O;
            }
            else
            {
                player = SquareState.X;
            }
        }

        Console.WriteLine("Player " + game.CheckWinner() + " wins!");
    }
}
