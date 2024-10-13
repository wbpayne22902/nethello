// See https://aka.ms/new-console-template for more information
using Color;
Console.WriteLine("Hello, World!".Color("#2FAEB4").Bold());
for(int x = 1; x <= 15; x++) {
    Console.WriteLine($"X = {x}");
}
Console.WriteLine("Done!".Color("#2390CF").Italic());
