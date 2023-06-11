Console.WriteLine("Напишите целое положительное число: ");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = 2;

if (number2 > number1)
{
    Console.WriteLine($"Нет четных положительных значений между 1 и числом  {number1} ");
    
}
while (number2 <= number1)
{
    Console.Write($"{number2} ");
    number2+=2;  
}
