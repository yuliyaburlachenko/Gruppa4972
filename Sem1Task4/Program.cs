// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа, и узнайте,какое из них имеет максимальное значение: ");

Console.Write("Введите первое число : ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum = 0;

if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;

Console.Write("Максимальное значение имеет число " + maxNum);

