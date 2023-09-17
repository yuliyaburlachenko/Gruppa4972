// Задача №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет 
//23432 -> да 
//12821 -> да

 using System;

public class Answer
{
    static bool IsPalindrome(int number){
    
      
      string num = Convert.ToString(number); 
      if (num.Length != 5) { Console.WriteLine("Число не пятизначное"); 
                           
      return false;
    } else if (num[0] == num[4] && num[1] == num[3]) return true;
      else return false;
      
    }
  
  //  метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           
            number = 445268;
        }

    
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
