string s="asdf"; //string(класс)ссылочный тип
// immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]);
for (int i = 0; i < s.Length; i++)
System.Console.WriteLine(s[i]);

// s[0]='S'; или 3 строки ниже
char[] cc=s.ToCharArray(); // строчку перебросить в массив символов
cc[0]='S';// в массиве сделать замену
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("asdf"); // обработать
sb[0]='s';
s=sb.ToString();

//for (int i = 0; i < 100000; i++)
//    s=s+"1"; // создается новая строка! так не делай!
for (int i = 0; i < 100000; i++)
    sb.Append("1"); // в эгой строке добавляет символ

// пример 1
string s1="Hello";
string s2="Hello";
System.Console.WriteLine((s1==s2)); // сравнить содержимое. s1==s2 или s1.CompareTo(s2)

// пример 2
Random random1=new Random();
Random random2=new Random();
System.Console.WriteLine(random1==random2);// сравнить адреса

// методы, с новой строки
//s1.Length// длина строки, метод
//s2=s1.Substring(2);// вырезать часть строки
//System.Console.WriteLine(s1.IndexOf("as"));// найти совпадение
//s2=s1.Replace('ab', 'ba'); // менять совпадения

