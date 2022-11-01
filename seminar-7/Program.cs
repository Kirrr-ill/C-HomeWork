
void ShowDoubleArray(double[] array)
{
    for(int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ShowDouble2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальная цифра: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальная цифра: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);
    return array;
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальная цифра: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальная цифра: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 1);
    return array;
}

ShowDouble2dArray(CreateDoubleRandom2dArray());


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1 7 -> числа с такими индексами в массиве нет

void FindElementOf2DArray(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if(row < array.GetLength(0) && column < array.GetLength(1))
        Console.WriteLine($"В строке {row} столбца {column} расположена цифра: {array[row - 1, column - 1]}");
    else Console.WriteLine("Значение находится за пределами массива!!");
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
FindElementOf2DArray(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[] AvgNumber(int[,] array)
{
    double[] doubleArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++, count++)
          doubleArray[i] += array[j, i];
        doubleArray[i] /= count;
    }
    return doubleArray;
}

int[,] myarray = CreateRandom2dArray();
Show2dArray(myarray);
ShowDoubleArray(AvgNumber(myarray));
