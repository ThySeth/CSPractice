private class Colorful {
     Random num = new Random();
     int r = num.Next(0, 256);
     int g = num.Next(0, 256);
     int b = num.Next(0, 256);
  static void Main(string[] args) {
    int[] rgb = {r, g, b}; // The array is unnecessary. Just wanted to practice a bit
    Console.WriteLine($"R: {rgb[0]}\nG: {rgb[1]}\nB: {rgb[2]}");
  }
}

public class Colourful {
    Random number = new Random();
    int R, G, B;
  static void Sub(string[] args) {
   Console.WriteLine("Which color do you want to get? [\"red\", \"green\", \"blue\", or \"all\"]");
    string choice = Console.ReadLine();
      switch(choice.toLower()) {
        case "red":
          R = number.Next(0, 256);
          Console.WriteLine($"Red: {R}");
        break;
        case "green":
          G = number.Next(0, 256);
          Console.WriteLine($"Green: {G}");
        break;
        case "blue":
          B = number.Next(0, 256);
          Console.WriteLine($"Blue: {B}");
        break;
        case "all":
          R = number.Next(0, 256);
          G = number.Next(0, 256);
          B = number.Next(0, 256);
            Console.WriteLine($"R: {R}\nG: {G}\nB: {B}");
        break;
          default: // Copy and pasted from above, obviously.
            R = number.Next(0, 256);
            G = number.Next(0, 256);
            B = number.Next(0, 256);
              Console.WriteLine($"R: {R}\nG: {G}\nB: {B}");
      }
   }
}
