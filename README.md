Sudoku Solver

  This is a simple C# program that solves a Sudoku puzzle using the backtracking algorithm. It takes a partially filled Sudoku grid as input, solves it, and prints the completed grid.

Features

  Input Validation: Ensures the entered numbers follow Sudoku rules during solving.
  Backtracking Algorithm: Efficiently finds the solution through recursive trial and error.
  User Input: Accepts a 9x9 grid as input with 0 representing empty cells.
  
How to Use

  Compile and Run the Program:
  Use any C# IDE (e.g., Visual Studio) or a .NET compiler to run the program.
  
  Input the Puzzle:
  
  Enter the Sudoku grid row by row. Each row should contain exactly 9 digits.
  Use 0 to represent empty cells.
  
  Example Input:
  
    530070000
    600195000
    098000060
    800060003
    400803001
    700020006
    060000280
    000419005
    000080079

  View the Output:

  If a solution exists, the program will display the solved Sudoku grid.
  If no solution is found, it will print:
  
    No solution found!

Code Overview

  Input Handling:
  
  Reads 9 rows of input from the user and stores the grid in a 2D array.
  Validation:
  
  The IsValid function ensures that placing a number in a specific cell follows Sudoku rules:
  
  No duplicates in the same row, column, or 3x3 sub-grid.
  
  Solving:
  
  The SolveSudoku function uses a backtracking algorithm to solve the puzzle:
  It tries numbers from 1 to 9 in each empty cell.
  If a number is valid, it places it and recursively solves the rest of the grid.
  If stuck, it backtracks and tries the next number.
  
  Output:
  The solved grid is printed using the PrintSudoku function.

  Example Run
  Input:
  
    530070000
    600195000
    098000060
    800060003
    400803001
    700020006
    060000280
    000419005
    000080079
    
  Output:

    Solved Sudoku:
    5 3 4 6 7 8 9 1 2 
    6 7 2 1 9 5 3 4 8 
    1 9 8 3 4 2 5 6 7 
    8 5 9 7 6 1 4 2 3 
    4 2 6 8 5 3 7 9 1 
    7 1 3 9 2 4 8 5 6 
    9 6 1 5 3 7 2 8 4 
    2 8 7 4 1 9 6 3 5 
    3 4 5 2 8 6 1 7 9 

Prerequisites
  .NET Core SDK or a C# IDE (e.g., Visual Studio).

Known Limitations

  The program assumes valid input; it does not validate whether the initial grid has a valid solution.
  Limited to standard 9x9 Sudoku grids.
  
Future Enhancements
  
  Add input validation to check if the provided grid is solvable.
  Support for different grid sizes (e.g., 4x4 or 16x16).
  Graphical interface for easier input.
  
License

This project is open-source and free to use. Feel free to modify and enhance it for personal or educational purposes!
