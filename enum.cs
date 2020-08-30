enum Years {
  2010,
  2015,
  2020,
}

class Program {
  static void Main(string[] args) {
   Years when = Years.2010
    switch(when) { // 2010
      case 2010:
        Console.Write("It was 2010!");
      break;
      case 2015:
        Console.Write("It was 2015!");
      break;
      case 2020:
        Console.Write("It's 2020!");
      break;
       default: 
         Console.Write("Well, that's not right.");
    }
  }
}
