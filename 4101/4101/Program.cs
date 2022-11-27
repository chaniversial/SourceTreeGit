using System;


while(true)
{
    string[] _info = Console.ReadLine().Split();
    if ((_info[0] == "0") && (_info[1] == "0"))
        break;
    int[] _array = { int.Parse(_info[0]), int.Parse(_info[1]) };
    if (_array[0] - _array[1] > 0)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");

}