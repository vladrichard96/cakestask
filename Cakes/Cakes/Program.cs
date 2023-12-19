Console.WriteLine("Введите количество гостей на чайном перерыве: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
List<int> factors = Factorize(n);
for (int i = 0; i < factors.Count; i++)
{
    sum += PrimeNumber(factors[i]);
}
Console.WriteLine(sum);
static List<int> Factorize (int x)
{
    List<int> factors = new List<int>();
    for (int i = 2; i <= Math.Sqrt(x); i++)
    {
        while (x%i == 0)
        {
            factors.Add(i);
            x /= i;
        }
    }
    if (x!=1) factors.Add(x);
    return factors;
}
static int PrimeNumber (int x)
{
    int count = 0;
    for (int i = 2; i <=x; i++)
    {
        if (IsPrime(i))
        {
            count++;
        }
    }
    return count;
}
static bool IsPrime(int number)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}