// Ввод-вывод двумерного массива, поиск в двумерном массиве, 
// сортировка двумерного массива(по колонкам, так как в дз 
// есть задание на сортировку по строкам).
/*
int[,] a = new int[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 4; j++)
        a[i, j] = random.Next(0, 10);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
        System.Console.WriteLine($"{a[i, j],4}");
    System.Console.WriteLine();
}
*/

int[,] Random2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}
// поиск в двумерном массиве(линейный)
bool LinearSearch2DArray(int[,] a, int find, out int i, out int j)// возвращаем позицию элементов, int find-искомое число
{
    for (i = 0; i < a.GetLength(0); i++)

        for (j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == find)
                return true;
    j = -1;
    return false;
}
// сортировка двумерного массива(пузырьковая)
void Sort2DArray(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)// для столбцов
        for (int k = 0; k < a.GetLength(0); k++)// колличество строчек
            for (int i = 0; i < a.GetLength(0) - 1; i++)// сравниваем, a.GetLength(0)-1 т.к. сравниваем два соседних элемента
                if (a[i, j] > a[i + 1, j])
                {
                    int t = a[i, j];// меняем
                    a[i, j] = a[i + 1, j];
                    a[i + 1, j] = t;
                }
}

int[,] a = Random2DArray(5, 5);
int find = 20; // условие поиска LinearSearch2DArray
a[2, 2] = find; // условие поиска LinearSearch2DArray, если оставить выводит в массиве, если // то Element not found
Print2DArray(a);
int i, j; // условие поиска LinearSearch2DArray
if (LinearSearch2DArray(a, find, out i, out j))
    System.Console.WriteLine($"Element {find} fount in position {i},{j}");
else
    System.Console.WriteLine("Element not found");
System.Console.WriteLine();

Sort2DArray(a);// вызываем сортировку
Print2DArray(a); // печатаем сортировку Sort2DArray