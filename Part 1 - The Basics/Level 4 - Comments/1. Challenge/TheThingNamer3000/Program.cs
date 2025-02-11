Console.WriteLine("What kind if thing are we talking about?"); //Ask the user what kind of thing they are talking about
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); /* Ask the user how they would describe the thing.*/
string b = Console.ReadLine();
string c = "Doom"; //This is the description of the thing
string d = "3000"; /* This is the version of the thing */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");