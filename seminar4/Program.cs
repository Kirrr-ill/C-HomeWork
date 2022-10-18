// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Stepen(double a, double b)
{
   double result = 1;
   for(int i = 0; i <= b; i++)
        result = result * a;    
    return Math.Pow(a, b);
}
Console.Write("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double b = Convert.ToInt32(Console.ReadLine());

double stepen = Stepen(a, b);
Console.WriteLine($"Результат: {a} в {b}й степени = " + stepen);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int num) 
{
  int sum = 0;
  string str = num.ToString();
  for (int i = 0; i < str.Length; i++)
     sum = sum + str[i] - '0';   
  return sum;
  
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumN = Sum(num);
Console.WriteLine("Сумма цифр в числе: " + sumN);


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]
// m = 3 -> [6, 1, 33]

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1); 
    return array;
}
void ShowArray(int[] array)
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
  Console.Write("]");
} 
Console.Write("Введите величину массива M: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
