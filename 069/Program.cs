// 69. Написать программу, упорядочивания по убыванию элементы 
// каждой строки двумерной массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] Number = new int[,]
{
    {1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
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
void Sort2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int k = 0; k < a.GetLength(1); k++)
            for (int j = 0; j < a.GetLength(1) - 1; j++)
                if (a[i, j] > a[i, j+1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j+1];
                    a[i, j+1] = t;
                }
}
System.Console.WriteLine("Задан массив");
Print2DArray(Number);
Sort2DArray(Number);
System.Console.WriteLine("Упорядоченный массив");
Print2DArray(Number);