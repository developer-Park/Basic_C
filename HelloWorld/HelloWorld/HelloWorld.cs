// See https://aka.ms/new-console-template for more information
using HelloWorld;

Console.WriteLine("Hello, World!");
Console.WriteLine("Completed");
String name = "parker";


// for, if same as Java
if (name =="parker") {
    for (int i = 0; i< 10; i++) {
        Console.WriteLine(name + i);
    }
}

// Calculator
Calculator cal = new Calculator();

int num1 = 0;
int num2 = 0;

//calculator
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.Write("Your option? ");
switch (Console.ReadLine())
{
    case "a":
        cal.addCal(num1,num2);
        break;
    case "s":
        cal.subCal(num1, num2);
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();


