// Напишите программу, которая на вход принимает три числа и выдает 
// максимальное из этих чисел
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22


Console.Clear();
Console.WriteLine("Введите число");
Console.WriteLine("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a != b)
{
if (a < b)
{
    Console.WriteLine("a < b " + a + "<" + b);
}
else
{
    Console.WriteLine("a > b " + a + ">" + b);
}
    }
else
{
    Console.WriteLine("a > b " + a + ">" + b);
}