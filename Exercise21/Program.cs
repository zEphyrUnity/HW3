//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] GetUserData()
{
    const int COORDINATE_NUMBER = 3;
    int[] userNumber = new int[3];

    for (int i = 0; i < COORDINATE_NUMBER; i++)
    {
        Console.Write($"координата {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out userNumber[i]))
        {
            Console.WriteLine("Введите число, а не строку!");
        }
    }
    return userNumber;
}

double VectorLength(int[] pointA, int[] pointB)
{
    return Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2));
}

Console.WriteLine("Введите координаты точки A");
int[] pointA = GetUserData();

Console.WriteLine("Введите координаты точки B");
int[] pointB = GetUserData();

double vectorAB = VectorLength(pointA, pointB);
Console.WriteLine("Длинна вектора AB {0:F2}", vectorAB);