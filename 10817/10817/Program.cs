string[] info = Console.ReadLine().Split();
int[] info2 = { int.Parse(info[0]), int.Parse(info[1]), int.Parse(info[2]) };

Array.Sort(info2);
Console.WriteLine(info2[1]);