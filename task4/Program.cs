// Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого числа.

void KillSecondNumber(int num)
{
    int numCount = num;
    int numLen = 1;
    while (numCount / 10 != 0)
    {
        numCount = numCount / 10;
        numLen++;
    }
    int tenPow = 1;
    while (numLen > 1)
    {
        tenPow = tenPow * 10;
        numLen--;
    }
    Console.WriteLine(num / tenPow * tenPow / 10 + num % (tenPow / 10));
}

Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
KillSecondNumber(x);
