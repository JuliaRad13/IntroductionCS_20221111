// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.WriteLine("Введите число:");
int SumNumbers(int Top)
{
    int sum=0;
    int digit=0;
    while (Top>0)
        {
            digit=Top%10;
            sum=sum+digit;
            Top=Top/10;
        }
        return sum;
}
int X=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сумма цифр в числе: ");
System.Console.WriteLine(SumNumbers(X));
