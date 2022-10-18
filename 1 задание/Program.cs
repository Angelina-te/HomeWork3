Console.WriteLine("Введите число: "); string number = Console.ReadLine(); 
int length = number.Length;

if (length == 5)
{
if (number[0] == number[4] && number[1] == number[3])    
// 0 1 2 3 4
//[1 1 2 1 2]
{
    Console.WriteLine($"{number} - Число является палиндромом");
}
else
{
    Console.WriteLine($"{number} - Чиисло не является палиндромом");
}
}

