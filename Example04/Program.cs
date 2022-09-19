Console.Write("Нпиши число: ");
float user_number = float.Parse(Console.ReadLine());
float index = 0;
while (index <= user_number)
{
    if (index % 2 == 0)
    { 
        Console.Write(index + ", ");
        index++;
    }
    else
    {
        index++;
    }

}

