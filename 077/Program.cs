﻿// 77. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности 0 и 1 
int Fibonacci(int N)
{
    if(N==0) return 0;
    else if (N==1) return 1;
    else return Fibonacci(N-1) + Fibonacci(N-2);
}
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}