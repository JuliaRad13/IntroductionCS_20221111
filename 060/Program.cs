// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами


int[,] Random2DArrayMN(int m, int n, int min = 0, int max = 20)
{
    int[,] a = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
void Print2DArrayMN(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],5}");
        System.Console.WriteLine();
    }
}
int[,] a = Random2DArrayMN(5, 5);
Print2DArrayMN(a);