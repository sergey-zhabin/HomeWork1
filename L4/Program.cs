
Console.WriteLine(" Введите число ограничив диапазон проверки ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while ( count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write (count + " ");
    }
    count++;
}

/*Числа которые требуется задать в диапазон поиска:
5 -> 2, 4
8 -> 2, 4, 6, 8*/

