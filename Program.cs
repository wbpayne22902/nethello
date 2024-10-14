// See https://aka.ms/new-console-template for more information
// Version 1.0
using Color;
Console.WriteLine("Hello, World!".Color("#2FAEB4").Bold());
for(int x = 1; x <= 15; x++) {
    Console.WriteLine($"x = {x}");
}
Console.WriteLine("Done with loop!".Color("#2390CF").Italic());

if(Environment.Is64BitProcess == true) {
    Console.WriteLine("This is 64 Bit!");
}

