// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNumber (int num)
{
    Console.WriteLine($"Число {num}, вторая цифра числа {num / 10 % 10}");
}

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
SecondNumber(x);
