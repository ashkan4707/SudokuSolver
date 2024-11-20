using System;

class Program
{
	static void Main()
	{
		int[,] sudoku = new int[9, 9];

		Console.WriteLine("Enter the Sudoku puzzle, row by row (9 digits per row, use 0 for empty cells):");

		
		for (int i = 0; i < 9; i++)
		{
			string input = Console.ReadLine();
			for (int j = 0; j < 9; j++)
			{
				sudoku[i, j] = int.Parse(input[j].ToString());
			}
		}

		if (SolveSudoku(sudoku))
		{
			Console.WriteLine("\nSolved Sudoku:");
			PrintSudoku(sudoku);
		}
		else
		{
			Console.WriteLine("No solution found!");
		}
	}

	static bool IsValid(int[,] board, int row, int col, int num)
	{
		for (int i = 0; i < 9; i++)
		{
			if (board[row, i] == num)
			{
				return false;
			}
		}

		for (int i = 0; i < 9; i++)
		{
			if (board[i, col] == num)
			{
				return false;
			}
		}

		int startRow = row / 3 * 3;
		int startCol = col / 3 * 3;
		for (int i = startRow; i < startRow + 3; i++)
		{
			for (int j = startCol; j < startCol + 3; j++)
			{
				if (board[i, j] == num)
				{
					return false;
				}
			}
		}

		return true;
	}

	static bool SolveSudoku(int[,] board)
	{
		for (int row = 0; row < 9; row++)
		{
			for (int col = 0; col < 9; col++)
			{
				if (board[row, col] == 0) 
				{
					for (int num = 1; num <= 9; num++) 
					{
						if (IsValid(board, row, col, num))
						{
							board[row, col] = num; 

							if (SolveSudoku(board)) 
							{
								return true;
							}

							board[row, col] = 0; 
						}
					}

					return false; 
				}
			}
		}

		return true; 
	}

	
	static void PrintSudoku(int[,] board)
	{
		for (int i = 0; i < 9; i++)
		{
			for (int j = 0; j < 9; j++)
			{
				Console.Write(board[i, j] + " ");
			}
			Console.WriteLine();
		}
	}
}
