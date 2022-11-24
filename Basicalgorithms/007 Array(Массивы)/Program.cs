

// массив - это объекты
int N=7;
int[] t;// не присвоенное 
t=new int[N];// создаем массив, то есть в t помещаем  адрес массива
// или int[] t=new int[N]
double s=0;
// заполнить массив
for(int i=0; i<N; i++) // или вместо N заменить t.Length на длину массива если он большой, и заменить все ниже на длину
    t[i]=Convert.ToInt32(Console.ReadLine());
// обработать массив
for(int i=0;i<N;i++)
    s=s+t[i];
    // вывод результата
    System.Console.WriteLine(s/N);
