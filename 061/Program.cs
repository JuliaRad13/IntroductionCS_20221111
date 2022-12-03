// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArrayMN(int m, int n, int min = 1, int max = 20)
{
    double[,] a = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            a[i, j] = Math.Round(random.NextDouble()*random.Next(min,max),2);
    return a;
}
void Print2DArrayMN(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],10}");
        System.Console.WriteLine();
    }
}
double[,] a = Random2DArrayMN(5, 5);
Print2DArrayMN(a);