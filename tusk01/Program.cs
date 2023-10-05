Console.WriteLine("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"да первое число: {numberA} квадрат второго: {numberB}");
}
else
{
    Console.WriteLine($"Нет число : {numberA} не квадрат числа{numberB}");
}
