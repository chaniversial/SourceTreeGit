string[] _info = Console.ReadLine().Split();
int[] _numinfo = { int.Parse(_info[0]), int.Parse(_info[1]), int.Parse(_info[2]) };
Array.Sort(_numinfo);
for(int i=0;i<3;i++)
{
    Console.Write(_numinfo[i]);
    Console.Write(" ");
}