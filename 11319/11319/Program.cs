using System.Text;

StringBuilder ans = new StringBuilder();

string[] info = { "a", "i", "o", "u", "e" };

int info2 = int.Parse(Console.ReadLine());
for(int i=0;i<info2;i++)
{
    int temp = 0;
    string[] sentence = Console.ReadLine().Split();
    string oneline = "";
    for (int j = 0; j < sentence.Length; j++)
        oneline += sentence[j].ToLower();
    for(int j=0;j<oneline.Length;j++)
    {
        for(int k=0;k<info.Length;k++)
        {
            if (oneline[j].ToString() == info[k])
            {
                temp++;
            }
        }
    }
    ans.Append(oneline.Length - temp);
    ans.Append(" ");
    ans.Append(temp);
    ans.Append("\n");
}
Console.Write(ans);