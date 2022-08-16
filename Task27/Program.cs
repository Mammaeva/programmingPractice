Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while (n > 0)
{
    summa = summa + n % 10;
    n /= 10;
}
Console.Write("Сумма: " + summa);
