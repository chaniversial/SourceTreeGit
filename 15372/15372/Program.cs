using System;

string[] info = Console.ReadLine().Split();

double a = double.Parse(info[0]);
double b = double.Parse(info[1]);

Console.Write((long)Math.Pow(a, b));