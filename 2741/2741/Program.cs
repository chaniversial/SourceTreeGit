using System.Text;

StringBuilder _strBuilder = new StringBuilder();

int info = int.Parse(Console.ReadLine());
for (int i = 0; i < info; i++)
{
    _strBuilder.Append(i + 1);
    _strBuilder.Append("\n");
}

Console.Write(_strBuilder);