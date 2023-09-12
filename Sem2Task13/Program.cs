// Задача 13
//Напишите программу,которая выводит третью цифру заданного числа или ссобщает,что третьей цифры нет.

int number = ReadLine("Введите число: ");

int count = number.ToString().Length;

Console.Write(MakeArray(number, count));


