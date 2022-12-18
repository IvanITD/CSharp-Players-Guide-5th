int provinces = int.Parse(Console.ReadLine());
int duchies = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());

provinces+= 6;
duchies+= 3;
estates++;

Console.WriteLine($"Provinces: {provinces}");
Console.WriteLine($"Duchies: {duchies}");
Console.WriteLine($"Estates: {estates}");
