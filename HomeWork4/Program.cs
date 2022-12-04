// Напишите программу, которая на вход ринимает число (N),
// а на выходе показывает все четные числа от 1 до N.
// 5 ->2, 4
// 8 ->2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while((count) <= N)
{
        Console.WriteLine("{0} ", count);
        count = count + 2;
}