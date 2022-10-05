// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());

while (N > 1)
{
    if (N % 2 == 0)
    {
        Console.Write(N + "  ");
    }
    N--;
}

while (N < 1)
{
    if (N % 2 == 0)
    {
        Console.Write(N + "  ");
    }
    N++;
}








//while (N < 1)
//{
//    if (N % 2 = 0)
//    {
//        Console.WriteLine(N);
//
//    }
//    else (N = N - 1);
//}