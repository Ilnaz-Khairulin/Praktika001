//Задача 23
//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


static void Cube(int number)
{
    int[] A = new int[number];
    int i = 0;
    while (i < number)
    {
        A[i] = Convert.ToInt32(Math.Pow((i + 1), 3));
        System.Console.Write(A[i] + ", ");
        i++;
    }
}


int number = new Random().Next(1, 10);
Console.WriteLine(number);
Cube(number);