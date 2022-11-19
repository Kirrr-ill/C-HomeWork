int[,] CreateRandom2dArray1() 
{
  Console.WriteLine("Задайте стороны массива.");
  Console.Write("Введите количество строк: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите минимальное число: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите максимальное число: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minVal, maxVal + 1);
  return array;
}

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 10);
    return array;    
}

void Show2dArray(int[,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}



// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortRows2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int temp;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
      for (int x = 0; x < array.GetLength(1) - j - 1; x++)
        if (array[i, x + 1] > array[i, x])
        {
          temp = array[i, x + 1];
          array[i, x + 1] = array[i, x];
          array[i, x] = temp;
        }
  }
}

// int[,] myArray = CreateRandom2dArray1();
int[,] myArray = CreateRandom2dArray(4, 4);
Show2dArray(myArray);
Console.WriteLine();
SortRows2dArray(myArray);
Show2dArray(myArray);



//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

void SumOfRows(int[,] array)
{
  int[] temp = new int [array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
          temp[i] += array[i,j];
  int rowSum = 1;
  int minVal = temp[0];
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    if(temp[i] < minVal)
      {
        minVal = temp[i];
        rowSum = i + 1;
      }
  }
    Console.WriteLine($"Строка с минимальной суммой элементов: {rowSum}");

}

int[,] rowArray = CreateRandom2dArray1();
Show2dArray(rowArray);
Console.WriteLine();
SumOfRows(rowArray);
    



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void TwoMatrixs (int[,] array1, int[,] array2)
{
    if(array1.GetLength(0) != array2.GetLength(1))
        Console.WriteLine("Неверный формат. Матрицы не совпадают!");
    else
    {
      int[,] array = new int[array1.GetLength(1), array2.GetLength(0)];
      for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
          for (int n = 0; n < array1.GetLength(0); n++)
             array[i,j] += array1[n,j] * array2[i,n];
      Show2dArray(array);
    }
}

void Show2dArrayMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]);
        if(i < array.GetLength(0)-1)
            Console.Write(" | ");
      else Console.Write("");
    }
    Console.WriteLine();
}

int[,] matrix1 = CreateRandom2dArray(2, 2);
int[,] matrix2 = CreateRandom2dArray(2, 2);

Show2dArrayMatrix(matrix1);
Show2dArrayMatrix(matrix2);
Console.WriteLine("Результирующая матрица: "); 
TwoMatrixs(matrix1, matrix2);



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void CreateRandom3dArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


void Show3dArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = 0; n < array.GetLength(2); n++)
      {
        Console.Write(array[i,j,n] + "(" + i + "," + j + "," + n + ")");
        if(n < array.GetLength(2) - 1)
           Console.Write("  ");
      }
      if(j < array.GetLength(1) - 1)
          Console.WriteLine("  ");
      else Console.WriteLine("  ");
    }
}

int[,,] array3D = new int[2, 2, 2];
CreateRandom3dArray(array3D);
Show3dArray(array3D);




//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4; 
// int n = new Random().Next(1, 10);
// Console.WriteLine($"Массив случайным размером от 1 до 10 ({n}) заполненный числами по спирали.");
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;
while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
      j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
      i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
      j--;
  else
      i--;
}

void ShowSpiralArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
         Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

ShowSpiralArray(matrix);