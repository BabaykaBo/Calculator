// Declare variables and then initialize to zero.
double num1 = 0;
double num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");

// Use a switch to do math
switch (Console.ReadLine()) 
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = {num1 + num2}");
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = {num1 - num2}");
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = {num1 * num2}");
        break;
    case "d":
        while (num2 == 0) {
            Console.WriteLine("Enter a non-zero divisor:");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Unknown option...");
        break;
}

// Wait for user to respond before clothing
Console.WriteLine("Press any key to close the Calculator console");
Console.ReadKey();

