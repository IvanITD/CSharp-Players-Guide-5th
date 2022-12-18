double chocolateEggsAmmount = int.Parse(Console.ReadLine());

double resultDivision = chocolateEggsAmmount / 4;
double resultRemainder = chocolateEggsAmmount % 4;

Console.WriteLine($"The ammount of eggs that each sister should get is: {resultDivision:F2}");
Console.WriteLine($"The remaining chocolate for the Duckbear is: {resultRemainder:F2}");