using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] gridToSolve =
            {
                {5,4,0,0,2,0,8,0,6},
                {0,1,9,0,0,7,0,0,3},
                {0,0,0,3,0,0,2,1,0},
                {9,0,0,4,0,5,0,2,0},
                {0,0,1,0,0,0,6,0,4},
                {6,0,4,0,3,2,0,8,0},
                {0,6,0,0,0,0,1,9,0},
                {4,0,2,0,0,9,0,0,5},
                {0,9,0,0,7,0,4,0,2}
            };

            Console.WriteLine("Grille de départ");
            ShowGrid(gridToSolve);
            Console.WriteLine();

            SolveTheGrid(gridToSolve);

            Console.WriteLine("Grille résolue");
            ShowGrid(gridToSolve);

        }
        public static void ShowGrid(int[,] grid)
        {

            for (int line = 0; line < grid.GetLength(0); line++)
            {
                for (int column = 0; column < grid.GetLength(1); column++)
                {
                    Console.Write(grid[line, column]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool SolveTheGrid(int[,] grid)
        {
            int[] emptyValue = FindEmptyValue(grid);

            if (emptyValue[0] == -1 && emptyValue[1] == -1)
            {
                return true;
            }

            for (int possibility = 1; possibility <= 9; possibility++)
            {
                if (IsAbsentOnLine(grid, emptyValue, possibility)
                     && IsAbsentOnColumn(grid, emptyValue, possibility)
                     && IsAbsentOnSquare(grid, emptyValue, possibility))
                {
                    grid[emptyValue[0], emptyValue[1]] = possibility;

                    if (SolveTheGrid(grid))
                    {
                        return true;
                    }

                    grid[emptyValue[0], emptyValue[1]] = 0;
                }
            }

            return false;
            
        }

        public static int[] FindEmptyValue(int[,] grid)
        {
            int[] cursor = new int[2];

            for (int line = 0; line < grid.GetLength(0); line++)
            {
                for (int column = 0; column < grid.GetLength(1); column++)
                {
                    if (grid[line, column] == 0)
                    {
                        cursor[0] = line;
                        cursor[1] = column;
                        return cursor;
                    }
                }
            }
            return new int[] {-1,-1};    
        }
        public static bool IsAbsentOnLine(int[,]grid, int[] cursor, int number)
        {
            int line = cursor[0];
            bool absent = true;

            for (int column = 0; column < grid.GetLength(1); column++)
            {
                if (grid[line, column] == number)
                    absent = false;
            }
            return absent;
        }

        public static bool IsAbsentOnColumn(int[,]grid, int[] cursor, int number)
        {
            int column = cursor[1];
            bool absent = true;

            for (int line = 0; line < grid.GetLength(0); line++)
            {
                if (grid[line, column] == number)
                    absent = false;
            }
            return absent;
        }
        public static bool IsAbsentOnSquare(int[,] grid, int[] cursor, int number) 
        {
            int[] squareNumber = SquareNumber(grid, cursor);
            int lineMinimum = squareNumber[0];
            int lineMaximum = squareNumber[1];
            int columnMinimum = squareNumber[2];
            int columnMaximum = squareNumber[3];

            bool absent = true;

            for (int line = lineMinimum; line < lineMaximum; line++)
            {
                for (int column = columnMinimum; column < columnMaximum; column++)
                {
                    if (grid[line, column] == number)
                        absent = false;
                }
            }
            return absent;
        }

        public static int[] SquareNumber(int[,] grid, int[] cursor)
        {
            int line = cursor[0];
            int column = cursor[1];
            int[] squareNumber = new int[4];

            if (line >= 0 && line <= 2 && column >= 0 && column <= 2)
            {
                squareNumber[0] = 0;
                squareNumber[1] = 2;
                squareNumber[2] = 0;
                squareNumber[3] = 2;
            }
            else if (line >= 0 && line <= 2 && column >= 3 && column <= 5)
            {
                squareNumber[0] = 0;
                squareNumber[1] = 2;
                squareNumber[2] = 3;
                squareNumber[3] = 5;
            }
            else if (line >= 0 && line <= 2 && column >= 6 && column <= 8)
            {
                squareNumber[0] = 0;
                squareNumber[1] = 2;
                squareNumber[2] = 6;
                squareNumber[3] = 8;
            }
            else if (line >= 3 && line <= 5 && column >= 0 && column <= 2)
            {
                squareNumber[0] = 3;
                squareNumber[1] = 5;
                squareNumber[2] = 0;
                squareNumber[3] = 2;
            }
            else if (line >= 3 && line <= 5 && column >= 3 && column <= 5)
            {
                squareNumber[0] = 3;
                squareNumber[1] = 5;
                squareNumber[2] = 3;
                squareNumber[3] = 5;
            }
            else if (line >= 3 && line <= 5 && column >= 6 && column <= 8)
            {
                squareNumber[0] = 3;
                squareNumber[1] = 5;
                squareNumber[2] = 6;
                squareNumber[3] = 8;
            }
            else if (line >= 6 && line <= 8 && column >= 0 && column <= 2)
            {
                squareNumber[0] = 6;
                squareNumber[1] = 8;
                squareNumber[2] = 0;
                squareNumber[3] = 2;
            }
            else if (line >= 6 && line <= 8 && column >= 3 && column <= 5)
            {
                squareNumber[0] = 6;
                squareNumber[1] = 8;
                squareNumber[2] = 3;
                squareNumber[3] = 5;
            }
            else if (line >= 6 && line <= 8 && column >= 6 && column <= 8)
            {
                squareNumber[0] = 6;
                squareNumber[1] = 8;
                squareNumber[2] = 6;
                squareNumber[3] = 8;
            }
            return squareNumber;
        }
    }
}
