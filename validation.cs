Console.WriteLine("How old are you?");

double age = Console.ReadLine();

if(String.IsNullOrWhiteSpace(age) || Double.isNaN(age)) throw new ArgumentException("You MUST specify your age!");

// [Type].isNullOrWhiteSpace(variable) makes sure the given variable isn't blank or null
// [#Type].isNaN(variable) checks if the given variable is not-a-number

if(age >= 18) {
  Console.WriteLine("Alright, go on through.");
} else {
  Console.WriteLine("Beat it, kid.");
}
