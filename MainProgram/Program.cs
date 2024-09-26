using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using static System.Console;

namespace MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 9;

            WriteLine("\n----------------------------------");
            WriteLine("Welcome to tic-tac-toe");
            WriteLine("----------------------------------");
            WriteLine("Players will take turns choosing an unoccupied cell.");
            WriteLine("The first player to get 3 in a row (or column or diagonal) wins!\n");

            char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            // will hold the winning player when there is one
            int winner = 0;

            for (int turn = 0; turn < MAX_TURNS; turn++)
            {
                // player X on even turns, player O on odd turns
                char currentPlayer = turn % 2 == 0 ? 'X' : 'O';
                WriteLine($"currentPlayer={currentPlayer}; turn={turn}");
                WriteLine("Current Board: ");
                DisplayBoard(board);
                MakeMove(currentPlayer, board);
                if (HasWinner(board))
                {
                    winner = currentPlayer;
                    break;
                }
            }
            DisplayBoard(board);

            // print the game outcome
            if (winner == 'X')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     X wins!    |");
                WriteLine("\\----------------/");
            }
            else if (winner == 'O')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     O wins!    |");
                WriteLine("\\----------------/");
            }
            else
            {
                WriteLine("Looks like a draw");
            }
        }

        // TODO: write the functions used in main (and any other helper functions you want to use)

        // DisplayBoard
        /**
         * displays the tic-tac-toe board
         * given the contents of the named cells
         *  a | b | c
         * ---+---+---
         *  d | e | f
         * ---+---+--
         *  g | h | i
         */
        public static void DisplayBoard(char[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
        }
        //GetMove
        /* Receive the following as parameters: 1) a string to prompt the user for input, 2) a copy of the board
         *   The user must enter a single character, 'a' through 'i', that's it.
         *   Verify the cell is valid (e.g. it is in the board, and no one has played there yet).   
         *   Also, you'll probably have a loop in here in case the user selects a cell that another player 
         *   already picked.  You'll need to ask again for them to pick another cell.      
         * Return: the index of the cell the player selected (if they want 'a' you'd return 0)
        */
        public static int GetMove(string prompt, char[] board)
        {
            Console.WriteLine(prompt);
            while (true)
            {

                int userInput = Convert.ToChar(Console.ReadLine()) - 97;
                if (userInput >= 0 && userInput <= 8)
                {
                    if ((int)board[userInput] == (userInput + 97))
                    {
                        return userInput;
                    }
                    else
                    {
                        Console.WriteLine("invalid input,already picked!");
                    }
                }
                Console.WriteLine("Pick a letter between a and i");
            }
        }
        //bool CellsAreTheSame(char a, char b, char c);
        /*
         *  returns true if a, b, and c are all the same
         */
        public static bool CellsAreTheSame(char a, char b, char c)
        {
            return a == b && b == c;
        }
        //MakeMove
        /* Receive the current player and the board as a parameter.
         * Call GetMove($"Player {currentPlayer}: Where do you want to play?").
         * Update the board at that index with the current player's symbol.
         */
        public static void MakeMove(char currentPlayer, char[] board)
        {
            int index = GetMove($"Player {currentPlayer}: Where do you want to play?", board);
            board[index] = currentPlayer;
        }
        //HasWinner
        /* given the board,
         * returns true if the board has a winner (8 possibilities: horizontal, vertical, or diagonal)
         */
        // hint: just return true if you can find three-in-a-row
        // of any character; consider writing the function 'CellsAreTheSame'
        // described below
        public static bool HasWinner(char[] board)
        {
            if(CellsAreTheSame(board[0],board[1],board[2]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[3],board[4],board[5]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[6],board[7],board[8]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[0],board[3],board[6]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[1],board[4],board[7]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[2],board[5],board[8]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[0],board[4],board[8]))
            {
                return true;
            }
            else if(CellsAreTheSame(board[2],board[4],board[6]))
            {
                return true;
            }
            return false;
        }
    }






}

