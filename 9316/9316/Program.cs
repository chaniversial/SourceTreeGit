using System.Text;

StringBuilder _strBuilder = new StringBuilder();

int info = int.Parse(Console.ReadLine());
for(int i=1;i<=info;i++)
{
    _strBuilder.Append("Hello World, Judge ");
    _strBuilder.Append(i);
    _strBuilder.Append("!\n");
}
Console.Write(_strBuilder);