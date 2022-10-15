
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Проверим ваше число на полиндром?");
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

void CheckingNumber(string num)
{
  if (num[0] == num[4] || num[1] == num[3]){
    Console.WriteLine($"Число {num} палиндром.");
  }
  else Console.WriteLine($"Число {num} не палиндром.");
}

if (num.Length == 5)
  CheckingNumber(num);

else Console.WriteLine("Введи пятизначное число!");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "a");
int y1 = Coordinate("y", "a");
int z1 = Coordinate("z", "a");
int x2 = Coordinate("x", "b");
int y2 = Coordinate("y", "b");
int z2 = Coordinate("z", "b");

int Coordinate(string coordinate, string point)
{
    Console.Write($"Введите координату {coordinate} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double length =  Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длинна отрезка {length}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void CubesArry(int[] cubeArry)
{
  int count = cubeArry.Length;
  int i = 1;
  while(i < count)
  {
    Console.Write(cubeArry[i] + " ");
    i++;
  }
} 

int[] arry = new int[cube + 1];
Cube(arry);
CubesArry(arry);
