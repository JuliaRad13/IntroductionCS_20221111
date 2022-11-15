System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

double max = a;

if(a > max) max = a;
if(b > max) max = b;

System.Console.Write("max = ");
System.Console.WriteLine(max);