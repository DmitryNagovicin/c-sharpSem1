//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:  ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
    Console.WriteLine($"Число {first} больше {second}");
}
else if (first < second)
{
    Console.WriteLine($"Число {second} больше {first}");
}
else
{
    Console.WriteLine($"Числа равны");
}