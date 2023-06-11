
Console.WriteLine("Напишите первое целое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе целое число");
string input_string2 = Console.ReadLine();
Console.WriteLine("Напишите третье целое число");
string input_string3 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
int number3 = Convert.ToInt32(input_string3);


int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;


Console.Write("max = ");
Console.WriteLine(max);
