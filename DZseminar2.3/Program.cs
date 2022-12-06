//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("введите число");
int n = Convert.ToInt32 (Console.ReadLine());
string str = n.ToString();
 if (n < 99)
 { 
   Console.WriteLine("третьей цифры нет"); 
 }
 else
 Console.WriteLine( str [2]);
