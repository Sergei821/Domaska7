//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] CreateArray(int row, int colons)
{
    double[,] array2D = new double[row, colons];
    return array2D;
}

void FillingArray(double[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = Math.Round(-9.9 + rnd.NextDouble() * (9.9 + 9.9), 2);

        }
    }
}

void PrintArrayInConsole(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "; ");
        }
        System.Console.WriteLine();
    }
}

int rows    = InputNumberWithMessage("Введите число строк массива: ");
int columns = InputNumberWithMessage("Введите число колонок массива: ");

double[,] array2D = CreateArray(rows, columns);
FillingArray(array2D);
PrintArrayInConsole(array2D);


