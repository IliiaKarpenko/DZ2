*ДЗ №2
Напишите смогла справиться
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите число: ");
String test = Console.ReadLine();

if (isPalidrom == true)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}


{
    for (int i = 0; i < test.Length - 1; i++) ;
}

int m = test.Length - 1 - i;

{
    palindrom = false;
}
return palindrom;
/*

*/
/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double x1, double y1, double x2, double y2, double z1, double z2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)  );
return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z1 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, x2, y2, z1, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
/*

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
Console.Write($"{Math.Pow(i, 3)} ");
/*


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

не СПРАВИЛАСЬ С НЕЙ, ЗАПУТАЛАСЬ 

int ThirdNum(int num)
{
  while (num > 999)
    {
    num /= 10;
    }
  return num % 10;
}

bool Other(int num)
{
  if (num < 999)
}

Console.WriteLine("третьей цифры нет");
return false

int RandNum = new Random().Next( 100, 1000);

int NewNum = ThirdNum (RandNum);

Console.WriteLine($"New version { ThirdNum } is { NewNum } ");
*/



/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

попыталась решить эту задачу, но не смогла. Смотрела код в интернете, тоже не поняла как делать


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= number);
{
  if (current % 2 == 0);
  {
    Console.Write(current + " ");
    current += 2;
  }
}



Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
 

Console.Write(" Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number1;

if( number1 > max) max = number1;
if( number2 > max) max = number2;

Console.Write(" max = ");
Console.WriteLine( max );

if( number1 < min) min = number1;
if( number2 < min) min = number2;

Console.Write(" min = ");
Console.WriteLine( min );



Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("Максимальное число = ");
Console.WriteLine ( max);


Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

 if ( num % 2 == 0)
 { 
    Console.Write ("Введенное число является четным");
     Console.ReadLine();
    }
    else {
      Console.Write ("Введенное число является Нечетным");
      Console.ReadLine();  
    }

*/



