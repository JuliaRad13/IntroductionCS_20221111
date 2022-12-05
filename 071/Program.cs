// 71. Показать натуральные числа от N до 1, N задано
/*
void NaturalNumber(int N, int i)
{
    if(N<=i)
    {
        System.Console.WriteLine(N);
        NaturalNumber(N+1, i);
    }
}
NaturalNumber(-10,1);
*/

// Показать натуральные числа от N до 1, N задано
void NaturalNumber(int N, int i)
{
    if(N>=i)
    {
        System.Console.WriteLine(N);
        NaturalNumber(N-1, i);
    }
}
NaturalNumber(10,1);
