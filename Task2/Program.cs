//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет
//1, 1 -> 1


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArray(int row, int Columns)
{
    int[,] array2D = new int[row, Columns];
    return array2D;
}

void FillingArray(int[,] array2D, int lefntRangeValue, int rightRangeValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(lefntRangeValue, rightRangeValue);
        }
    }
}

void PrintArrayInConsole(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SearchForAnArrayElementPositionArray2D(int[,] array2d)
{
    int rows = InputNumberWithMessage("Укажите индекс строки : ");
    int columns = InputNumberWithMessage("Укажите индекс столбца: ");
    if (rows > array2d.GetLength(0) || columns > array2d.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет!");
    }
    else
    {
        Console.WriteLine(array2d[rows, columns]);
    }

}

int rows = InputNumberWithMessage("Введите число строк массива: ");
int columns = InputNumberWithMessage("Введите число колонок массива: ");

int[,] array2D = CreateArray(rows, columns);
FillingArray(array2D, 1, 10);
PrintArrayInConsole(array2D);
System.Console.WriteLine();
SearchForAnArrayElementPositionArray2D(array2D);

