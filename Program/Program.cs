int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < a; i += 1)
{
    List<int> b = new List<int>();
    int c = Convert.ToInt32(Console.ReadLine());
    string[] d = Console.ReadLine().Split();

    foreach (string item in d)
    {
        b.Add(int.Parse(item));
    }

    List<int> e = new List<int>();

    for (int j = 0; j < c; j += 2)
    {
        e.Add(b[j]);
    }

    Console.WriteLine($"result = {e.Max() + e.Count}");

}
