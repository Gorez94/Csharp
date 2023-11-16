/*67. Напишите программу, которая будет принимать
 на вход число и возвращать сумму его цифр.
 */

 System.Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int intN(int first)
{
    if (first % 10 > 0)
    return first % 10 + intN(first / 10);
    else
    return 0;
}

int result = intN(number1);
System.Console.WriteLine(result);