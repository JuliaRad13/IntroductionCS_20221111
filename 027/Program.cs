// 27. Возведите число А в натуральную степень B используя цикл

System.Console.WriteLine("Введите число A:");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B:");
int B=Convert.ToInt32(Console.ReadLine());
int count=1;
int result=A;
while (count<B)
{
    result=result*A;
    count++;
}
System.Console.WriteLine($"{A}*{B}={result}");
 