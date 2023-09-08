//Задача 5
//Напишите программу,которая на вход принимает одно число,а на выходе показывает все целые числа,в промежутке от -N до N .

int a = int.Parse(Console.ReadLine()??"0");
if (a < 0) a = -a;
for(int i = -a; i <= a; i++){

    Console.Write(i);
    Console.Write(" ");
}

