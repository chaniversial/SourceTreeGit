﻿int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if ((x > 0) && (y > 0))
    Console.Write(1);
else if ((x < 0) && (y > 0))
    Console.Write(2);
else if ((x < 0) && (y < 0))
    Console.Write(3);
else
    Console.Write(4);