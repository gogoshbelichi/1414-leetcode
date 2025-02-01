List<int> hash = fibNums(19);
foreach (int fibNum in hash)
{
    Console.WriteLine(fibNum);
}

int x = FindMinFibonacciNumbers(19);
Console.WriteLine($"Count: {x}");


static int FindMinFibonacciNumbers(int k) {
    List<int> fibonacciNumbers = fibNums(k);
    fibonacciNumbers.Reverse();
    if (fibonacciNumbers.Contains(k))
    {
        return 1;
    }
    int count = 0;
    int sum = 0;
    while (sum != k)
    {
        foreach (int item in fibonacciNumbers)
        {
            if (sum == k) break;
            if (sum+item > k) continue;
            sum += item;
            count++;
        }
    }
    return count;
}

static List<int> fibNums(int k) {
    List<int> fibonacciNumbers = new List<int>();
    int a = 0, b = 1;
    while (true) // 10^9
    {
        if (a > k) break;
        int next = a + b;
        fibonacciNumbers.Add(a);
        a = b;
        b = next;
    }
    return fibonacciNumbers;
}