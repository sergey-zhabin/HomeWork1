Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberA > numberB)
{
     max =  numberA;
     min = numberB;
 }
else 
{
     max =  numberB;
     min = numberA;
}
Console.WriteLine("max число =" + max);
Console.WriteLine("min число =" + min);

//проверить требуется три пары чисел:
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3