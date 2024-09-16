//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void SecondNumb()
{
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Вы ввели: "+n);
if (n<100) Console.WriteLine("третьей цифры нет");
else if(n>999)
    {
        Console.WriteLine("Вы ввели не трехзначное число:)");
    }
else 
    {
        int secondnum = n % 100 / 10;
        Console.WriteLine("Вторая цифра введенного числа: " + secondnum);
    }
}



SecondNumb();

