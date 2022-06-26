
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
     max =  numberB;
     if (numberC > max)
    {
        max = numberC;
    }
     else 
    {
        max =numberB;
    }
}
else 
{
     max =  numberA;
    
     if (numberC > max)
    {
        max = numberC;
    }
     else 
    {
        max =numberA;
    } 
}     

Console.WriteLine("max =" + max);

/* проверить требуется три тройки чисел:
 2, 3, 7 -> 7
 44 5 78 -> 78
 22 3 9 -> 22 */