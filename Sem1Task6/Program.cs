﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Вводим число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");

// Проверим на четность (т.е деление на два без остатка)
if (numTest % 2 == 0 ) Console.WriteLine($"Число: {numTest} - Четное"); 
else Console.WriteLine($"Число: {numTest} - Нечетное");  


