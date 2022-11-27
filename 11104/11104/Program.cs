using System;
using System.Text;

StringBuilder ans = new StringBuilder();

int info = int.Parse(Console.ReadLine());
for(int i=0;i<info;i++)
{
    double temp = 0;
    string _info = Console.ReadLine();
    for(int j=_info.Length - 1;j>=0;j--)
    {
        if (_info[j] == '1')
        temp += Math.Pow(2, _info.Length - 1 - j);
    }
    ans.Append(temp);
    ans.Append("\n");
}
Console.Write(ans);