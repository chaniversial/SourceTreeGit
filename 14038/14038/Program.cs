int cnt = 0;
for(int i=0;i<6;i++)
{
    string num = Console.ReadLine();
    if (num == "W")
        cnt++;
}
if (cnt >= 5)
    Console.WriteLine(1);
else if (cnt >= 3)
    Console.WriteLine(2);
else if (cnt >= 1)
    Console.WriteLine(3);
else
    Console.WriteLine(-1);