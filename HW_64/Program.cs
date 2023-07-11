// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Write("Введите значение N ,больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());
void NumberCounter (int n)
{
    if (n < 0) 
    Console.Write($"{n} не натуральное число");
    if (n == 0) return;
    Console.Write("{0,4}", n);
    NumberCounter (n - 1);
}

NumberCounter(n);


