// 72. Показать натуральные числа от M до N, N и M заданы


int NaturalNumber(int a, int b)
{
    if (a == 0 && b == 0) return 0;
    else if (a == b) return a;
    else if (a < b || a > b)
        return NaturalNumber(a + 1, b);
    else return NaturalNumber(b - 1, a);
}
System.Console.WriteLine(NaturalNumber(6, 1));


int NaturalNumber(int a, int b)
{
    if (a == 0 && b == 0) return 0;
    else if (a == b) return a;
    else if (a < b)
    {    
        System.Console.WriteLine(a);
        return NaturalNumber(b, a+1);
    }
    else if (a > b)
    {
        System.Console.WriteLine(b);
        return NaturalNumber(a, b+1);
    }
}
       System.Console.WriteLine(NaturalNumber(1, 6));