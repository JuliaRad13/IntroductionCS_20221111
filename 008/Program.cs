//9. Вывести на экран числа от -N до N

int N=Convert.ToInt32(Console.ReadLine());
int i=-N;
while (i<=N)
{
 System.Console.Write($"{i} ");
 i=i+1; 
}
/*int N=Convert.ToInt32(Console.ReadLine());
for(int i=-N;i<=N;i++)
System.Console.WriteLine($"{i} ");
*/