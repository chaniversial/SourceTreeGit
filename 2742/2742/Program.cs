using System.Text;

StringBuilder _strBuilder = new StringBuilder();

int num = int.Parse(Console.ReadLine());
for(int i=num; i>0;i--)
{
    _strBuilder.Append(i);
    _strBuilder.Append("\n");
}

Console.Write(_strBuilder);