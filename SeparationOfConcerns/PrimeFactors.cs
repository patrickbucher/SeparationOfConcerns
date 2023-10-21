public class PrimeFactors
{
    public static void Factor(List<int> numbers)
    {
        // first, compute prime numbers up to number
        var primesUpToNumber = new Dictionary<int, List<int>>();
        foreach (var number in numbers)
        {
            primesUpToNumber.Add(number, new List<int>());
            for (var candidate = 2; candidate <= number; candidate++)
            {
                var isPrime = true;
                for (var i = 2; i < candidate; i++)
                {
                    if (candidate % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesUpToNumber[number].Add(candidate);
                }
            }
        }

        // TODO: this is just debugging code
        foreach (var number in primesUpToNumber.Keys)
        {
            Console.Write($"{number}: ");
            foreach (var prime in primesUpToNumber[number])
            {
                Console.Write($"{prime} ");
            }
            Console.WriteLine();
        }

        // second, factorize number by its primes
        foreach (var number in primesUpToNumber.Keys)
        {
            var primes = primesUpToNumber[number];
        }
    }
}
