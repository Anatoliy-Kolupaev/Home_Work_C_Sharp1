Console.Write("Нaпиши первое число: ");
int user_number1 = int.Parse(Console.ReadLine());
Console.Write("Нaпиши второе число: ");
int user_number2 = int.Parse(Console.ReadLine());
if (user_number1 > user_number2)
{
    Console.WriteLine("Max = " + user_number1);
    Console.WriteLine("Min = " + user_number2);
}
else
{
    Console.WriteLine("Max = " + user_number2);
    Console.WriteLine("Min = " + user_number1);
}