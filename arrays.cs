Random random = new Random(); 
// If you're familiar w/ JS/NodeJS, works the same as Math.random();
// Randomization is more simplistic by using "random.Next(min, max);"

// string[]

string[] a = ["What's up?", "Hello, World!", "Foo? Bar?", "<Programmer Humor>"]; // array.Length;

Console.WriteLine(a[random.Next(0, a.Length-1)]);

// int[]

int[] b = [5, 12, 21, 22];

Console.WriteLine(b[random.Next(0, a.Length-1)]);

// Array Sorting //

char[] alphabetical = ["b", "c", "d", "a"]; // Unsure if char[] is the correct variable for arrays containing characters

Array.Sort(alphabetical);
Console.WriteLine(alphabetical);

// Math In Arrays //

int c[] = [2, 4, 11];

Console.WriteLine(c.Sum()); // All numbers in the array added together
Console.WriteLine(c.Max()); // Highest number in the array
Console.WriteLine(c.Min()); // Smallest number in the array

