// Prints text to the console
Console.WriteLine("What kind of thing are we talking about?");

// Reads User's text input from the console
string a = Console.ReadLine();

// Prints text to the console
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Reads User's text from the console
string b = Console.ReadLine();

// Stores the text, "of Doom", into a varible of type 'string'
string c = "of Doom";

// Stores the text, "3000", into a variable of type 'string'
string d = "3000";

// Prints text to the console, while using interpolation
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");