int info = int.Parse(Console.ReadLine());
string[] data = Console.ReadLine().Split();

int ans = 0;
for(int i=0;i<5;i++)
{
    if (info == int.Parse(data[i]))
        ans++;
}
Console.WriteLine(ans);