// 93.  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49


int[,] Number = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7},
};

int[,] Number2 = new int[,]
{
{1, 5, 8, 5},
{4, 9, 4, 2},
{7, 2, 2, 6},
{2, 3, 4, 7},
};

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

int[,] Proizvedenie(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0) || a.GetLength(1) != b.GetLength(0))
        throw new ArgumentException("Матрицы невозможно перемножить");
    int[,] sum = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
                sum[i, j] += a[i, k] * b[k, j];
        }
    }
    return sum;
}
System.Console.WriteLine("Задан массив");
Print2DArray(Number);
System.Console.WriteLine();
Print2DArray(Number2);

System.Console.WriteLine("Произведение матриц:");

int[,] Number3 = Proizvedenie(Number, Number2);
Print2DArray(Number3);

