﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа, и узнайте,какое из них большее,а какое меньшее. ");
Console.Write("Ввести первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine("Число" + num1 + "большее" );
    Console.Write("Число" + num2 + "меньшее");
}
    else if (num1 == num2)

{
    Console.WriteLine("Число " + num2 + "большее");
}

    else

{
    Console.WriteLine("Число " + num2 + "болшее");
    Console.Write("Число " + num1 + "меньшее");
}
