string[] info = Console.ReadLine().Split();
ulong n = ulong.Parse(info[0]);
ulong m = ulong.Parse(info[1]);

if (n == m)
    Console.WriteLine(1);
else
    Console.WriteLine(0);