using System;
using System.Text;


StringBuilder _strBuilder = new StringBuilder();

int _case = int.Parse(Console.ReadLine());
for(int i=0;i<_case;i++)
{
    string[] info = Console.ReadLine().Split();
    _strBuilder.Append(int.Parse(info[0]) + int.Parse(info[1]));
    _strBuilder.Append("\n");
}
Console.Write(_strBuilder);