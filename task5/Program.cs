string ChooseWord(int n)
{
    if (n >= 5 & n <= 20) return "программистов";
    else if (n % 10 == 1) return "програмист";
    else if (n % 10 >= 2 & n % 10 <= 4) return "программиста";
    return "программистов";
}

Console.Write("Введите количество программистов в комнате: ");
int progNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В комнате {progNumber} {ChooseWord(progNumber)}");
