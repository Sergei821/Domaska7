//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void SearchArithmeticMeanColumnsArray2D(int[,] array2d)
{
    double arithmeticMean = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        for (int j = 0; j < array2d.GetLength(0);j++)
        {
            arithmeticMean += array2d[j, i];
        }
        Console.WriteLine(Math.Round(Convert.ToDouble(arithmeticMean / array2d.GetLength(0)), 2));
    }
    
}

int rows = InputNumberWithMessage("Введите число строк массива: ");
int columns = InputNumberWithMessage("Введите число колонок массива: ");

int[,] array2d = CreateArray(rows, columns);
FillingArray(array2d, 1, 10);
PrintArrayInConsole(array2d);
System.Console.WriteLine();
SearchArithmeticMeanColumnsArray2D(array2d);


