//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdNumb()
{
Console.WriteLine("Программа показывает третью цифру в веденном Вами числе.");
Console.WriteLine();
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
        int thirdnum = n%10;
        Console.WriteLine("Третья цифра введенного числа: " + thirdnum);
    }
}
ThirdNumb();

