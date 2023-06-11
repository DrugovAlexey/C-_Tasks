
Console.WriteLine("Напишите первое целое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе целое число");
string input_string2 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
if (number2 > number1)
{
    Console.WriteLine($"Число {number2} больше, а число {number1} меньше");
}
else
{
    Console.WriteLine($"Число {number1} больше, а число {number2} меньше");
}
if (number2 == number1)
{
    Console.WriteLine($"Первое число {number2} и второе число {number1} одинаковые");
}
