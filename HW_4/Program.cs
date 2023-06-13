Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberB;
if (numberA > numberB)
{
    Console.WriteLine ($"Максимальное число {numberA}");
}
if (numberC > numberA)
{
    Console.WriteLine ($"Максимальное число {numberC}");
}
else
{
    Console.WriteLine ($"Максимальное число {numberB}");
}
