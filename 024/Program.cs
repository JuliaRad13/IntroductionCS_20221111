// 24. Вывести на экран таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
for (int a=1;a<=N;a++)
{
    System.Console.Write($"{a*a} ");
}