using System.Text;

StringBuilder ans = new StringBuilder();


int num = int.Parse(Console.ReadLine());
for(int i=0;i<num;i++)
{
    int info = int.Parse(Console.ReadLine());
    for(int j=0;j<info;j++)
    {
        ans.Append("=");
    }
    ans.Append("\n");
}

Console.Write(ans);