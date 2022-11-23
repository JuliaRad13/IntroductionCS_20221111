/*
// результат не меняет значение(формула не работает)
void Swap(int a, int b)
{
int t=a;
a=b;
b=t;
}
int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(a,b);
System.Console.WriteLine($"a={a} b={b}");
*/

/*
void Swap(ref int a, ref int b)// reference-ссылка
{
int t=a;
a=b;
b=t;
}
int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
*/


//????
void Calculator(int a, int b, ref int sum, ref int multi)
{
    sum=a+b;
    multi=a*b;
}
int a=3, b=5;
int sum=0, multi=0;
System.Console.WriteLine($"a={a} b={b}");
Calculator(a, b, ref sum, ref multi);