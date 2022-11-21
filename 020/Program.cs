// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
//причем X ≠ 0 и Y ≠ 0


/*double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int part=0;

if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x>0 && y<0) part=3;
if (x>0 && y<0) part=4;

System.Console.WriteLine("Part:"+part);
*/

//тип имя (аргументы)
int Part(double x, double y)
{
// тело подпрограммы
    int part=0;
    if (x>0 && y>0) part=1;
    if (x<0 && y>0) part=2;
    if (x>0 && y<0) part=3;
    if (x>0 && y<0) part=4;
    return part;
}
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Part:"+Part(x,y));