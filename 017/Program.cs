// 17.Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным.
System.Console.WriteLine("Введите число:");
int n=Convert.ToInt32(Console.ReadLine());
if (n==7 || n==6) System.Console.WriteLine("YES"); 
else System.Console.WriteLine("NO");
