Console.WriteLine("+---------+------------+--------------+");
Console.WriteLine("| Decimal |  Binary    | Hexadecimal  |");
Console.WriteLine("+---------+------------+--------------+");

Console.WriteLine($"| {0,7} | {Convert.ToString(0, 2).PadLeft(4, '0'),10} | 0x{0:X,-11}       |");
Console.WriteLine($"| {1,7} | {Convert.ToString(1, 2).PadLeft(4, '0'),10} | 0x{1:X,-11}       |");
Console.WriteLine($"| {2,7} | {Convert.ToString(2, 2).PadLeft(4, '0'),10} | 0x{2:X,-11}       |");
Console.WriteLine($"| {3,7} | {Convert.ToString(3, 2).PadLeft(4, '0'),10} | 0x{3:X,-11}       |");
Console.WriteLine($"| {4,7} | {Convert.ToString(4, 2).PadLeft(4, '0'),10} | 0x{4:X,-11}       |");
Console.WriteLine($"| {5,7} | {Convert.ToString(5, 2).PadLeft(4, '0'),10} | 0x{5:X,-11}       |");
Console.WriteLine($"| {6,7} | {Convert.ToString(6, 2).PadLeft(4, '0'),10} | 0x{6:X,-11}       |");
Console.WriteLine($"| {7,7} | {Convert.ToString(7, 2).PadLeft(4, '0'),10} | 0x{7:X,-11}       |");
Console.WriteLine($"| {8,7} | {Convert.ToString(8, 2).PadLeft(4, '0'),10} | 0x{8:X,-11}       |");
Console.WriteLine($"| {9,7} | {Convert.ToString(9, 2).PadLeft(4, '0'),10} | 0x{9:X,-11}       |");
Console.WriteLine($"| {10,7} | {Convert.ToString(10, 2).PadLeft(4, '0'),10} | 0x{10:X,-11}       |");

Console.WriteLine("+---------+------------+--------------+");