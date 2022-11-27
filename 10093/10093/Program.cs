using System.Text;

StringBuilder ans = new StringBuilder();

string[] info = Console.ReadLine().Split();
ulong a = ulong.Parse(info[0]); 
ulong b = ulong.Parse(info[1]);
if(a==b)
{
    Console.WriteLine("0");
    return;
}
if(a>b)
{
    ulong temp = a;
    a = b;
    b = temp;
}
ans.Append(b - a - 1);
ans.Append("\n");
for(ulong i=a+1;i<b;i++)
{
    ans.Append(i);
    ans.Append(" ");
}
Console.Write(ans);