// 31. Сгенерировать 10 случайных чисел. 
//Показать кубы тех чисел, которые заканчивающится на четную цифру

/*int r=10;
double x=r;// не явное приведение типов
double x=23;
//int o=Convert.ToInt32(x);
int o=(int)x;// явное привидение типов
*/

bool Test(int a);
{
    //if (a%2==0) return true; else return false;
    return a%2==0;
}

Random random=new Random(10);
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(b))
    System.Console.WriteLine($"{a}, {b}");
}
   

