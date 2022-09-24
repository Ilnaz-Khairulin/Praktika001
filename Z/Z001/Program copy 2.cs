//Задача 23
//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

partial class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        number = new Random().Next(1, 10);
        Console.WriteLine(number);

        int[] arye = new int[number];
        int i = 0;
        while (i < number)
        {
            arye[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
            i++;
        }
        Console.WriteLine(arye[i]);
    }
}