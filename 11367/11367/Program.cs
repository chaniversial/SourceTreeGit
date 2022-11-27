using System.Text;

StringBuilder ans = new StringBuilder();

int size = int.Parse(Console.ReadLine());
for(int i=0;i<size;i++)
{
    string[] info = Console.ReadLine().Split();
    ans.Append(info[0] + " ");
    if (int.Parse(info[1]) <= 59)
        ans.Append("F\n");
    else if ((int.Parse(info[1]) >= 60) && (int.Parse(info[1]) <= 66))
        ans.Append("D\n");
    else if ((int.Parse(info[1]) >= 67) && (int.Parse(info[1]) <= 69))
        ans.Append("D+\n");
    else if ((int.Parse(info[1]) >= 70) && (int.Parse(info[1]) <= 76))
        ans.Append("C\n");
    else if ((int.Parse(info[1]) >= 77) && (int.Parse(info[1]) <= 79))
        ans.Append("C+\n");
    else if ((int.Parse(info[1]) >= 80) && (int.Parse(info[1]) <= 86))
        ans.Append("B\n");
    else if ((int.Parse(info[1]) >= 87) && (int.Parse(info[1]) <= 89))
        ans.Append("B+\n");
    else if ((int.Parse(info[1]) >= 90) && (int.Parse(info[1]) <= 96))
        ans.Append("A\n");
    else
        ans.Append("A+\n");
}
Console.Write(ans);