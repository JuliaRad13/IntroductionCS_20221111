char c='a'; //тип char может хранить только 1 символ
c='\x64'; // указать код символа
c='\u0064'; // юникод 00(1б) 64(2б)
char b='a';// char(структура)
System.Console.WriteLine((int)b);// преобразовать, увидеть код символа, привидение типа
System.Console.WriteLine(c.ToString()+b.ToString()); //ToString(конвектирует в строку)
if (b>='0' && b<='9') System.Console.WriteLine("It`s digit"); // проверить на соответствие
if (b>='A' && b<='Z') System.Console.WriteLine("It`s big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It`s  Latin");

if (char.IsDigit(b)) System.Console.WriteLine("It`s digit");// является ли ввведенный симвод цифрой



