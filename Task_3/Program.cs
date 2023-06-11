Console.WriteLine("Напишите целое число");
string input_string1 = Console.ReadLine();
int number = Convert.ToInt32(input_string1);

if (number  == 0)
{
    Console.WriteLine($"Число {number} является четным числом, в википедии так написано))");
}

if (number != 0 & number % 2 == 0)
{
    Console.WriteLine($"Число {number} четное");
}
if (number != 0 & number % 2 != 0)
{
    Console.WriteLine($"Число {number} нечетное");
}

