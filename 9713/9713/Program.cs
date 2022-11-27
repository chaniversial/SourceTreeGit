using System.Text;

StringBuilder _strBuilder = new StringBuilder();

int _case = int.Parse(Console.ReadLine());
int ans = 0;
for(int i=0;i<_case;i++)
{
    int temp = int.Parse(Console.ReadLine());
    ans = 0;
    for (int j = 1; j <= temp; j += 2)
        ans += j;
    _strBuilder.Append(ans);
    _strBuilder.Append("\n");
}
Console.Write(_strBuilder);