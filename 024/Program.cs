// 24. Вывести на экран таблицу квадратов чисел от 1 до N
/*
System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
for (int a=1;a<=N;a++)
{
    System.Console.Write($"{a*a} ");
}
*/

//System.Console.WriteLine("Введите число:");
//int N=Convert.ToInt32(Console.ReadLine());
int N=10;
for (int a=1;a<=N;a++)
System.Console.WriteLine($"{a,4}{a*a,10}");