using System;
using System.Text;

StringBuilder _strBuilder = new StringBuilder();
int _case = int.Parse(Console.ReadLine());
for (int i = 0; i < _case; i++) 
{
    int info = int.Parse(Console.ReadLine());
    _strBuilder.Append("Pairs for ");
    _strBuilder.Append(info);
    _strBuilder.Append(": ");

    for(int j=1;j<=info / 2;j++)
    {
        int a = j;
        int b = info - a;
        if(a<b)
        {
            _strBuilder.Append(a);
            _strBuilder.Append(" ");
            _strBuilder.Append(b);
            if (info % 2 == 1)
            {
                if(a<info/2)
                _strBuilder.Append(", ");
            }

            else if (info % 2 == 0)
            {
                if(a<info/2 - 1)
                _strBuilder.Append(", ");
            }
            
        }    
    }
    _strBuilder.Append("\n");
}
Console.Write(_strBuilder);