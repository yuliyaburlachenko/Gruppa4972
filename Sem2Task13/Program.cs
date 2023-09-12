// Задача 13
//Напишите программу,которая выводит третью цифру заданного числа или ссобщает,что третьей цифры нет.

int a = int.Parse(Console.ReadLine());

int i = (int)Math.Log10(a)-2;

Console.WriteLine(i < 0 ? "Третьей цифры нет" : (a % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i)).ToString());

Console.ReadLine();



