// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
   {
    Console.Write("Большее: " + n1 + " " + "Меньшее: " + n2);
    }
else
   {
    Console.Write("Большее: " + n2 + " " + "Меньшее: " + n1);
   }  


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n1 > max) max = n1;
if(n2 > max) max = n2;    
if(n3 > max) max = n3;

Console.WriteLine("Максимальное число: " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
   {
    Console.WriteLine("Чётное");
   }
else
    {
        Console.WriteLine("Не чётное");
    }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res < n1)
       {
        Console.WriteLine(res + 1);
        res = res + 2;
       }