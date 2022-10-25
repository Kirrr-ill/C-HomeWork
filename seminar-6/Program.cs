// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void PositiveNumbers()
{
  Console.Write("Какое количество чисел сравнить: ");
  int size = Convert.ToInt32(Console.ReadLine());
  int count = 0;
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
        count++;
  }
  Console.WriteLine($"Чисел больше ноля: {count}.");
}

PositiveNumbers();



// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Intersections()  
{
    Console.Write("Введите точку прямой 1. A = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите точку прямой 1. B = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите точку прямой 2. A = ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите точку прямой 2. B = ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения X: {x}");
    Console.WriteLine($"Точка пересечения Y: {y}");
}

Intersections();


