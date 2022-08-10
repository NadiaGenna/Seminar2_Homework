
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите положительное трёхзначное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

int SecondNumber = (firstNumber % 100) / 10;
    Console.Write("Вторая цифра этого числа -> " + SecondNumber);
