// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int Num(int arg, int arg1)
{
  if (arg == arg1) return arg;
  else return Num(arg, arg1 - 1) + arg1;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = Num(M, N);
Console.WriteLine(result);