using System;
using System.Text;

int index = 0;
StringBuilder _strBuilder = new StringBuilder();
while(true)
{
    int n0 = int.Parse(Console.ReadLine());
    int n1, n2, n3, n4;
    if (n0 == 0)
        break;
    else
    {
        n1 = n0 * 3;
        if(n1%2==0)
            n2 = n1 / 2; 
        
        else
            n2 = (n1 + 1) / 2;

        n3 = n2 * 3;
        n4 = n3 / 9;

        index++;
        _strBuilder.Append(index);
        _strBuilder.Append(". ");
        if (n1 % 2 == 1)
            _strBuilder.Append("odd ");
        
        else
            _strBuilder.Append("even ");
        _strBuilder.Append(n4);
        _strBuilder.Append("\n");
    }
}
Console.Write(_strBuilder);