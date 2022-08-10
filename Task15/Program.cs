//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, согласно дню недели: ");
int dayDigit = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayDigit)
{
    if (dayDigit == 6 || dayDigit == 7)
    {
        Console.WriteLine("(Этот день выходной) -> да");
    }
    else if (dayDigit < 1 || dayDigit > 7)
    {
        Console.WriteLine("Такого дня недели не существует, введите цифры в диапазоне от 1 до 7:");
    }
    else Console.WriteLine("(Этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayDigit);
