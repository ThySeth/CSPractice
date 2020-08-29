Console.WriteLine("Give me a number, any number!");
double a = Console.ReadLine();

Console.WriteLine($"Alright we got {a}, now give me another!");
double b = Console.ReadLine();

double sum = a + b;
Console.WriteLine($"And the grand total is... {sum}!!!");

if(a < b) {
  Console.WriteLine($"{b} is greater than {a}!") 
} else if(a > b) {
  Console.WriteLine($"{a} is greater than {b}!"); 
} else {
  Console.WriteLine($"{a} and {b} are equal!"); 
}

// Simplifies but more complex //
// (x < y) is the subject
// ? calls for an if/else
// : calls for else

String aResult = (a < 10) ? "The first number is less than 10!" : "The first number is greater than 10!";

Console.WriteLine(aResult);

String bResult = (b < 10) ? "The second number is less than 10!" : "The second number is greater than 10!";

Console.WriteLine(bResult);
