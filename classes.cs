class Halloween {
  public string date = "Saturday October 31st, 2020"; // Accessed by using ".date"
}

class WhenIsHalloween {
 static void Main(string[] args) {
  Halloween when = new Halloween();
  
  Console.WriteLine("When is Halloween?");
  
  Console.WriteLine(when.date); // Returns the string predefined in the Halloween class
 }
}

// Fields and Methods //

class SprSum {
  string spring = "Saturday March 20th, 2021";
  string summer = "Sunday June 20th, 2021";
  public void Issue(string culprit) {
    Console.WriteLine($"{culprit} isn't a valid response!");
  }
}

class Running {
  static void Main(string[] args) {
    SprSum season = new SprSum();
     Console.WriteLine("Which season do you want to know the date of? (Spring or Summer?)");
      string response = Console.ReadLine();
       switch(response.toLowerCase()) {
        case spring:
          Console.WriteLine(season.spring);
        break;
        case summer:
          Console.WriteLine(season.summer);
        break;
         default:
           Issue(response);
     }
  }
}
