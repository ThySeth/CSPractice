// String function //

static void Functional(string name = "Seth") {
  Console.WriteLine($"Wazzaaa {name}!");
}

// "= "Seth"" will be the default if the function arguments are left empty
// Just having "string name" will still function like the pre-defined version above, it just will not function if left empty

// Math function //

static void Add(int x, int y) {
  int sum = x + y;
   Console.WriteLine(sum);
}

// Executing the functions //

static void Main(string[] args) {
  Functional("Dave"); // Returns "Wazzaaa Dave!"
  Functional(); // Returns "Wazzaaa Seth!"
  Add(10, 10); // Returns "20"
}
