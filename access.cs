/* 
Access Modifiers:
Public - Accessible to all classes
Private - Only accessible to the current class
Protected - Same as "Private" but also allows access to classes inherited from the class itself
Internal - Only accessible with it's own assembly
*/

// Usage for PUBLIC //
// This will probably be more useful when using the same variable or method for several processes.
class PublicExample {
  public string name = "Seth";
}

class RunProgram {
  static void Main(string[] args) {
    PublicExample info = new PublicExample;
      Console.WriteLine($"My name is {info.name}!");
  }
}

class PublicExample {
  public string name = "Niel";
    static void Main(string[] args) {
      PublicExample info = new PublicExample;
        Console.WriteLine($"My name is {info.name}!");
    }
}

///
// Correct usage for PRIVATE //
///

class PrivateExample {
  private string isp = "AT&T";
  
  static void Main(string[] args) {
    PrivateExample internet = new PrivateExample();
      Console.WriteLine($"My ISP is {internet}!");
  }
}

///
// Incorrect usage for PRIVATE //
// Since "class PrivateExample" is not apart of the main process, the contents of the class cannot be used anywhere else
///
class PrivateExample {
  private string isp = "AT&T";
}

class RunProgram {
  static void Main(string[] args) {
    PrivateExample internet = new PrivateExample();
      Console.WriteLine($"My ISP is {internet}!");
  }
}
