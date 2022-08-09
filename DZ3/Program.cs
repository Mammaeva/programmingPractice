//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void WeekDay()
{
Console.WriteLine("Данная программа показывает день недели по введенной цифре.");
Console.WriteLine();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7) Console.WriteLine("день недели не отпределен, попробуйте снова.");
switch (num)
{
    case  1:
    Console.WriteLine("Пн - Не выходной");
    break;
    case 2:
    Console.WriteLine("Вт - Не выходной");
    break;
    case 3:
    Console.WriteLine("Ср - Не выходной");
    break;
    case 4:
    Console.WriteLine("Чт - Не выходной");
    break;
    case 5:
    Console.WriteLine("Пт - Не выходной");
    break;
    case 6:
    Console.WriteLine("Сб - Выходной");
    break;
    case 7:
    Console.WriteLine("Вс - Выходной");
    break;
}
}

 WeekDay();   

