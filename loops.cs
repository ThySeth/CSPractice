// Do/While //
int a = 17;

do { // Do everything in here
  Console.WriteLine(a);
  a++;
}
while(a > 5); // While "a" is greater than 5

// While //

int b = 0;

while(b < 10) {
  Console.WriteLine(b);
  b++;
}

// For //

for(int c = 200; c > 100; c-20) {
  Console.WriteLine(c);
}

// ForEach //

string[] days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
foreach(string aDay in days) {
  // "string aDay" holds one entry every loop from left to right
  // "in days" selects which array to pull entries from. Basically "in [array]"
  Console.WriteLine(aDay);
}
