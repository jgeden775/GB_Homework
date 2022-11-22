using static System.Console;

Clear();

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = GetMatrix(3, 3, 1, 9);
int[,] matrix2 = GetMatrix(3, 3, 1, 9);

if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Нельзя умножить данные матрицы");
    return;
}

DoublePrintMatrix(matrix1, matrix2);
WriteLine();
PrintMatrix(MultMatrix(matrix1, matrix2));

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void DoublePrintMatrix(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Write($"{matrix1[i, j]} " );
        }
        Write("| ");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j]} " );
        }
        WriteLine();
    }
}

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} " );
        }
        Console.WriteLine();
    }
}
