using System.IO;

string fileContent = "Welcome to the world!";
File.WriteAllText("example.txt", fileContent); // Creates a new file with the "fileContent"

string readFile = File.ReadAllText("example.txt");
Conole.WriteLine(readFile); // Returns "Welcome to the world!"
