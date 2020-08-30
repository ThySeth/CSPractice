Console.WriteLine("What is your first name?");

string name = Console.ReadLine();

switch(name.toLowerCase();) {
  case "john":
    Console.WriteLine("John?");
  break;
  case "nick":
    Console.WriteLine("Nick?");
  break;
  case "seth":
    Console.WriteLine("Seth!");
  break;
   default:
    Console.WriteLine("Who?");
}
