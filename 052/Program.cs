// 52. Написать программу преобразования десятичного числа в двоичное
/*
int n=13;
string s="";
while(n!=0)
{
    System.Console.Write(n%2);// для отладки
    s=n%2+s;
    n/=2;
}
System.Console.WriteLine();
System.Console.WriteLine(s);
*/
// Подпрограмма
string DecimalToBin(int n)
{
    string s="";
    if (n==0) return "0";
    while(n!=0)
    {
        s=Convert.ToString(n%2)+s;
        n/=2;
    }
    return s;
}
System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(7));