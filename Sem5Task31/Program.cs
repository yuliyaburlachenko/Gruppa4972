﻿//Задача 31
//Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных 
//элементов массива.
//Например: 
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма 
//отрицательных равна -20.

﻿//Заполняем одномерный массив


int[] GenArray(int num, int lowBorder, int highBorder){
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

(int, int) NegotivPositivSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for(int i =0;i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
            posSum=posSum+arr[i];
        }
        else
        {
            negSum+=arr[i];
        }
    }
    return (posSum,negSum);
}

int[] array = GenArray(12,-9,9);
PrintArray(array);
(int pos, int neg) sum = NegotivPositivSum(array);

Console.WriteLine("Сумма >0 :"+sum.pos+" Сумма <0 :"+sum.neg);

