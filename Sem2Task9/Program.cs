﻿// Задача 9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.


void Variant1()
{
    Console.WriteLine("Способ 1");

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    //34
    //34/10 = 3
    int firstDigit = number / 10;
    //34%10 = 4
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant2()
{
    Console.WriteLine("Способ 2");

    System.Random numberGenerator1 = new System.Random();
    int number1 = numberGenerator1.Next(10, 100);
    Console.WriteLine(number1);

    Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));


}


Variant1();
Variant2();
