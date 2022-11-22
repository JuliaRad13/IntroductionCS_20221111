// 26. Найти сумму чисел от 1 до А

System.Console.WriteLine("Введите число:");
int SumNumber(int A)
{
    int number=1;
    int sum=0;
    for (int i=0; i<A; i++)
        {
            sum=sum+number;
            number++;
        }
        return sum;
}
    int A=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(SumNumber(A));
