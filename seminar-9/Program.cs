//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int n)
{
  if (n < 1) 
	return;
   Console.Write(n + " ");
  ShowNumbers(n -1);
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);



//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum(int n, int m)
{
		if (n < m) 
		return n += SumNum(n + 1, m);
			if (n > m) 
			return n += SumNum(n - 1, m);
		else 
		return n;
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от M: {m} до N: {n} равна: {SumNum(m, n)}");



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
	if (m == 0)
	return n + 1;
		if (m > 0 && n == 0)
		return FunctionAkkerman(m - 1, 1);
	else
	return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {FunctionAkkerman(m, n)}");