Console.Write("Нпиши первое число: ");
float user_number1 = float.Parse(Console.ReadLine());

if (user_number1 % 2 == 0)
{
    Console.Write("Число " + user_number1  + " четное");
} 
else
{
    Console.Write("Число  " + user_number1 + " нечетное");
}
