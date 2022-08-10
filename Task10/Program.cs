
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число: ");
int firstNumber = int.Parse(Console.ReadLine());
if (firstNumber < 0)
{
    Console.WriteLine ($"Вторая цифра этого числа -> {firstNumber * -1 % 100 /10}");
}
else
{
int SecondNumber = (firstNumber % 100) / 10;
 Console.Write("Вторая цифра этого числа -> " + SecondNumber);
}