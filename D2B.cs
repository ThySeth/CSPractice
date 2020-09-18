public class Binary {
  static void Main(string[] args) { // terms[runs] = value;
   Console.WriteLine("Specify a number!");
   int i = Console.ReadLine();
    bool isNaN(i) return Console.WriteLine("Hey! Give me an integer, pal.");
     int[] binary = [];
      int placement = 0;
     if(i >= 128) {
       binary[placement] = 1;
        i - 128;
         if(i < 0) return i + 128; binary[placement] = 0;
         ++placement;
     }
     if(i >= 64) {
       binary[placement] = 1;
        i - 64;
        if(i < 0) return i + 64; binary[placement] = 0;
         ++placement;
     }
     if(i >= 32) {
       binary[placement] = 1;
        i - 32;
        if(i < 0) return i + 32; binary[placement] = 0;
         ++placement;
     }
     if(i >=16) {
       binary[placement] = 1;
        i - 16;
        if(i < 0) return i + 16; binary[placement] = 0;
         ++placement;
     }
     if(i >= 8) {
       binary[placement] = 1;
        i - 8;
        if(i < 0) return i + 8; binary[placement] = 0;
         ++placement;
     }
     if(i >= 4) {
       binary[placement] = 1;
        i - 4;
        if(i < 0) return i + 4; binary[placement] = 0;
         ++placement;
     }
     if(i >= 2) {
       binary[placement] = 1;
        i - 2;
        if(i < 0) return i + 2; binary[placement] = 0;
         ++placement;
     }
     if(i >= 1) {
       binary[placement] = 1;
        i - 1;
         ++placement;
     }
     if(i == 0) {
       binary[placement] = 1;
     }
     
     string final = Join(" ", binary);
     
     Console.WriteLine($"Binary of '{i}': {final}");
  }
}
