//Задача 21
//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

static void Rezalt(int[] A, int[] B){

    double AB = 0;
    AB = Convert.ToDouble(Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2)));
    AB = Math.Round(AB, 2);
    System.Console.WriteLine(AB);
}

int[] A = { 3, 6, 8 };
int[] B = { 2, 1, -7 };
Rezalt(A, B);

