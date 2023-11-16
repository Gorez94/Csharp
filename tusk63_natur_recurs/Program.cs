/*63. Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.
*/

Console.WriteLine("Введите число N: ");
int user = Convert.ToInt32(Console.ReadLine());

void intN(int user, int current=1)
{
    if (user < current) return;
    else
    {
    System.Console.Write(current + " ");
    intN(user,current +1);
    }
}

intN(user);