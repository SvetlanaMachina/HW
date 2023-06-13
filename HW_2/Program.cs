// See https://aka.ms/new-console-template for more information
// напишите программу, которая нв вход принимает два числа и выдает какое большее, какое - меньшее

Console.Write ("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine ($"Максимальное число {numberA}");
}
else
{
    Console.WriteLine ($"Максимальное число {numberB}");
}