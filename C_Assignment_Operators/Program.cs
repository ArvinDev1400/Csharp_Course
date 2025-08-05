int a = 10;
Console.WriteLine("مقدار اولیه a: " + a);

a += 5;
Console.WriteLine("بعد از a += 5: " + a); // 15

a -= 3;
Console.WriteLine("بعد از a -= 3: " + a); // 12

a *= 2;
Console.WriteLine("بعد از a *= 2: " + a); // 24

a /= 4;
Console.WriteLine("بعد از a /= 4: " + a); // 6

a %= 5;
Console.WriteLine("بعد از a %= 5: " + a); // 1

a = 6;
a &= 3;
Console.WriteLine("بعد از a &= 3: " + a); // 2 (6 & 3 = 110 & 011 = 010)

a |= 1;
Console.WriteLine("بعد از a |= 1: " + a); // 3 (010 | 001 = 011)

a ^= 2;
Console.WriteLine("بعد از a ^= 2: " + a); // 1 (011 ^ 010 = 001)

a <<= 2;
Console.WriteLine("بعد از a <<= 2: " + a); // 4 (0001 -> 0100)

a >>= 1;
Console.WriteLine("بعد از a >>= 1: " + a); // 2 (0100 -> 0010)