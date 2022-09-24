//Задача 19
//Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Напишите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

int a = 0, a1 = 0, b = 0, b1 = 0;
a = number / 10000;
a1 = (number / 1000) % 10;
b = number % 10;
b1 = (number / 10)%10;

if (a == b && a1 == b1)
{
    System.Console.WriteLine("Число являеться полиандром.");
}  
else
{
    System.Console.WriteLine("Число не является полиандром.");
}


//Number;
//Print;
