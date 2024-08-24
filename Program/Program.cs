// Inputs
int a = int.Parse(Console.ReadLine());
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

// variables
int one = 0;
int extraOne = 0;
int two = 0;
int three = 0;
int four = 0;

// four
foreach (int item in b)
{
    if (item == 4)
    {
        four += 1;
    }
}

// one
foreach (int item in b)
{
    if (item == 1)
    {
        one += 1;
    }
}

// three
foreach (int item in b)
{
    if (item == 3 && one != 0)
    {
        three += 1;
        one -= 1;
    }
    else if (item == 3 && one == 0)
    {
        three += 1;
    }
}

// two
foreach (int item in b)
{
    if (item == 2)
    {
        two += 1;
    }
}

if (two % 2 == 0)
{
    two /= 2;
}
else if (two % 2 != 0 && two != 1 && one < 2)
{
    two -= 1;
    two /= 2;
    two += 1;
}
else if (two % 2 != 0 && two != 1 && one > 1)
{
    two -= 1;
    two /= 2;
    two += 1;
    one -= 2;
}
else if (two == 1 && one > 1)
{
    one -= 2;
}


Console.WriteLine($"{one}, {two}, {three}, {four}");