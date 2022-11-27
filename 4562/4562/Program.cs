using System.Text;

StringBuilder _strBuilder = new StringBuilder();

int _testCase = int.Parse(Console.ReadLine());
for(int i=0;i<_testCase;i++)
{
    string[] _info = Console.ReadLine().Split();
    int[] _realInfo = { int.Parse(_info[0]), int.Parse(_info[1]) };
    if (_realInfo[0] - _realInfo[1] < 0)
        _strBuilder.Append("NO BRAINS\n");
    else
        _strBuilder.Append("MMM BRAINS\n");
}
Console.Write(_strBuilder);