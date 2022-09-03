// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumberOrNot(int num)
{
    if (num / 100 % 10 == 0) Console.WriteLine("Третьей цифры нет");
    else Console.WriteLine(num / 100 % 10);
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
ThirdNumberOrNot(a);
