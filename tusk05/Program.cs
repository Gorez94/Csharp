Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i <= n; i = i + 1)
{
    System.Console.Write(i+" ");
}