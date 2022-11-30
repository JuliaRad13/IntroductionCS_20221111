// 51. С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

/*
System.Console.Write("Введите число"); 
int Count(int a)
{
    int count=0;
    for (int i = 0; i < a; i++)
        if (a > 0) count++; 
    return count; 
}
int X=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Кол-во элементов > 0: {Count(X)}");
*/

/*
Console.Write("Введите число N: ");  
int q = Convert.ToInt32( Console.ReadLine() );
int Number (int n=0)
{
  int z = 0;
  for (int i=0 ; i<n; i = i + 1)
    {    
        Console.WriteLine("Введите число: "); 
        int a = Convert.ToInt32( Console.ReadLine());
        if (a>0) z = z+1; 
    }   return z;    
} 

Console.WriteLine($"Больше ноля = {0}", (Number(q)));
*/
Console.Write("Введите число: ");
int[] a = Convert.ToInt32(Console.ReadLine());
int count = 0;
 
for (int i = 0; i < a.Length; i++)
    if (a[i] > 0)
    {
        count++;
    }
Console.WriteLine($"Кол-во элементов > 0: {count}");