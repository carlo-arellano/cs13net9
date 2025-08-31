for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Console.Write("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz");
    }
    else
    {
        Console.Write(i);
    }

    // put a comma and space after every number except 100
    if (i < 100) Console.Write(", ");

    // write a carriage-return after every ten numbers
    if (i % 10 == 0) Console.WriteLine();
}
Console.WriteLine();