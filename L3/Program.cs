Console.WriteLine("Введите число требующеся проверить ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число четное ");
}
else
{
    Console.WriteLine("Число нечетное ");
}
/* Числа, которые требуется проверить:
4 -> да
-3 -> нет
7 -> нет*/