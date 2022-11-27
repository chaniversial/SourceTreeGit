string[] info = Console.ReadLine().Split();
int a = int.Parse(info[0]);
int b = int.Parse(info[1]);
if (a < b)
    Console.Write("<");
else if (a > b)
    Console.Write(">");
else
    Console.Write("==");