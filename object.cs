public Person {
  public string name { get; set; }
  public int age { get; set; }
  public string team { get; set; }
  
  public Info(string name, int age, string team) {
    Name = name;
    Age = age;
    Team = team;
  }
}

class Program {
  static void Main(string[] args) {
  Console.WriteLine("What's the new player's name?");
  string x = Console.ReadLine();
  String.IsNullOrWhiteSpace(x) return "Please specify their name next time.";
  Console.WriteLine($"How old is {x}?");
  int y = Console.ReadLine();
  Int.isNullOrWhiteSpace(y) return "Please provide their age next time.";
  if(y <= 17) return $"{x} cannot join the tournament! They must be 18 years or older.";
  Console.WriteLine("What team are they apart of?");
  string z = Console.ReadLine();
  String.IsNullOrWhiteSpace(z) return "Please provide their team next time.";
  
    Person information = new Person(x, y, z);
    Console.WriteLine($"Review:\nName: {information.Name}\nAge: {information.Age}\nTeam: {information.Team}");
    Console.WriteLine("Is all the information correct?");
    string yayNay = Console.ReadLine();
    if(yayNay.toLower() === "yes") {
      Console.WriteLine("Terrific!");
    } else {
      Console.WriteLine("Alright.");
    }
  }
}
