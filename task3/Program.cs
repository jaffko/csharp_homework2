// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

void IsWeekend(int num)
{
    if (num == 6 ^ num == 7) Console.WriteLine("Выходной!");
    else if (num <= 0 ^ num > 7) Console.WriteLine("Это не день недели!");
    else Console.WriteLine("Еще не выходной :(");
}

Console.WriteLine("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
IsWeekend(day);
