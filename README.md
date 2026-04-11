

📘 Matrix Transpose Program (C#)

📌 Description

This C# program creates a 3×3 matrix, displays it on the screen, and then prints its transpose.

A transpose of a matrix is formed by converting rows into columns.
That means:

Element at position [i, j] becomes [j, i].

🧠 How the Program Works

A 2D integer array arr1 is declared and initialized:
int[,] arr1 = { 
    { 1, 2, 3 }, 
    { 4, 5, 6 }, 
    { 7, 8, 9 } 
};

The original matrix is printed using nested for loops.

The transpose is printed by swapping the indices:

Console.Write(arr1[j, i] + " ");
🖥️ Output
matrix:
1 2 3
4 5 6
7 8 9

transpose:
1 4 7
2 5 8
3 6 9
📂 Concepts Used

2D Arrays

Nested for loops

GetLength() method

Matrix Transpose logic

🎯 Purpose

This program helps beginners understand:

How 2D arrays work in C#

How matrix indexing works

The concept of matrix transpose.
