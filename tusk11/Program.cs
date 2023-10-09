/* Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Random random = new Random();
int number = random.Next(100,1000);
Console.WriteLine(number);

int firstNumber = number / 100;
int threeNumber = number % 10;
int result = firstNumber * 10 + threeNumber;

Console.WriteLine(result);