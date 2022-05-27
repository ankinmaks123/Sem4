int schet(int number)
{
    int count = 0;
    Console.Write($"Сумма цифр равна {number} = ");
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }
    return count;    
}

Console.WriteLine(schet(54));
Console.WriteLine(schet(44));
Console.WriteLine(schet(176230));