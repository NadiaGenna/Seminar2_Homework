
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());

int thirdNumber = ThirdNumber(number);
if (number <= 1)
{
    Console.WriteLine("-> третьей цифры нет"); 
}else
{
    Console.WriteLine("третья цифра -> " + thirdNumber);
}
static int ThirdNumber(int count)
{
    while (count <= -1000 || count >= 1000) count /= 10;
    int digit = count % 10;
    return digit;

}
