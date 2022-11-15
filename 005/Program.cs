//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
double c=Convert.ToDouble(Console.ReadLine());

double max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

System.Console.Write("max = ");
System.Console.WriteLine(max);