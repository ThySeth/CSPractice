class Program {
  static void Main(string[] args) {
    Console.WriteLine("Give me a string!");
    try{
      string response = Console.ReadLine();
    } catch(Exception e) { 
      Console.WriteLine($"ERROR:\n{e}");
    }
  }
}
