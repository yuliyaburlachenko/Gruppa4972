﻿// Задача 11
//Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int ran = new System.Random().Next(100, 1000); 

System.Console.WriteLine(ran); 

char[] digitChar = ran.ToString().ToCharArray();

 System.Console.Write(digitChar[0]); 

 System.Console.Write(digitChar[2]);
