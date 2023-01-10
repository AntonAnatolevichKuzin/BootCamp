using System.Diagnostics;
// Stopwatch sw = new();
// sw.Start();

// int n = 1111111;
// string s = String.Empty;
// for (int i = 0; i < n; i++) s += "+";
// Console.WriteLine(s

// sw.Stop();
// Console.WriteLine($"time = {sw.ElapsedMilliseconds}");


//int n = 5;
//int[] array = new int[5];
//for (int i = 0; i < 5; i++)
//    array[i] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("[" + string.Join(" ", array) + "]");
//Console.WriteLine(array[3]);
// Сложность алгоритма 0(1)

// [4, 5, 3, 1, 2]
// [1, 2, 3, 4, 5] - 0(n*log n)
// ((5 + 1/2) * 5 - 0(1)

//int sum = 0;
//for (int i = 0; i < n; i++)
//    sum += array[i];

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + j) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}

for(int i = 0; i < n;i ++)
{
    for(int j = 0; j < n;j ++)
    {
        Console.Write(matrix[i, j]);
        Console.Write("  ");
    }
    Console.WriteLine();
}