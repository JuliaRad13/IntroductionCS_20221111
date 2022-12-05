// 70. Показать натуральные числа от 1 до N, N задано

void NaturalNumber(int N, int i)
{
    if(i<=N)
    {
        System.Console.WriteLine(i);
        NaturalNumber(N, i+1);
    }
}
NaturalNumber(10,1);