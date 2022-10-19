
int[] CreateRandomArray(int size, int min, int max)
{
  int[] array = new int[size];
  for(int i = 0; i < size; i++)
      array[i] = new Random().Next(min, max + 1); 
  return array;
}

int[] CreateArray(int size)
{
    int[] array = new int [size];
    Console.WriteLine("Создаём массив:");
    for(int i = 0; i< size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
    }
        Console.WriteLine("Завершено!");
    return array;
}

int ShowArray(int[] array)
{
  int size = array.Length;
  int i = 0;
  Console.Write("[");  
  while(i < size)
  {
    Console.Write(array[i]);
        i++;    
    if (i < size)
       Console.Write(", ");
  }
  Console.Write("] ");
  Console.WriteLine();
return size;
} 


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int NumArray(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0) 
            count++;
    return count;
}
Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr  = CreateRandomArray(num, 100, 999);
ShowArray(arr);
Console.WriteLine($"В массиве - {NumArray(arr)} чётных чисел");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumArr(int[] arr) 
{
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
        if((i + 1) % 2 == 0) 
            count += arr[i];
    return count;
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(size, min, max);
ShowArray(arr);
Console.WriteLine($"Сумма случайных чисел стоящих на нечётных позициях массива - {SumArr(arr)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int SumMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i])
            min = arr[i];
        if(max < arr[i])
            max = arr[i];
    }
    return max - min;
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(size, min, max);
ShowArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива - {SumMinMax(arr)}");
