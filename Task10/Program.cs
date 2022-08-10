
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int Digit3Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Digit3Number);
Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);