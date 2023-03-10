using System.Diagnostics;


int size = 1_000_000;
int m = 30_000;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

// // Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t += array[j];
    }
    if (t > max) max = t;
}
Console.WriteLine(max);
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
sw.Reset();

sw.Start();

int max1 = 0;
for (int j = 0; j < m; j++) max1 += array[j];
int t1 = max1;
for (int i = 1; i < array.Length - m; i++)
{
    t1 = t1 - array[i - 1] + array[i + (m - 1)];
    if (t1 > max1) max1 = t1;
}
sw.Stop();
Console.WriteLine(max1);
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");




