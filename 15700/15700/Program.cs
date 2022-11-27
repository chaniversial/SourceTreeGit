string[] info = Console.ReadLine().Split();
ulong n = ulong.Parse(info[0]);
ulong m = ulong.Parse(info[1]);
ulong size = n * m;
if (size % 2 != 0)
    size--;
    
Console.WriteLine(size/2);