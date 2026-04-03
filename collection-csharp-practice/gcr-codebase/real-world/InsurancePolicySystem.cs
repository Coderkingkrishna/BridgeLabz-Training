using System;
using System.Collections.Generic;

class InsurancePolicySystem
{
    class Policy
    {
        public int PolicyNumber;
        public string CoverageType;
        public DateTime ExpiryDate;
    }

    class ExpiryComparer : IComparer<Policy>
    {
        public int Compare(Policy x, Policy y)
        {
            int result = x.ExpiryDate.CompareTo(y.ExpiryDate);
            return result == 0 ? x.PolicyNumber.CompareTo(y.PolicyNumber) : result;
        }
    }

    static void Main()
    {
        HashSet<int> uniquePolicies = new HashSet<int>();
        List<Policy> insertionOrder = new List<Policy>();
        SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>(new ExpiryComparer());

        Console.WriteLine("Enter number of policies:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Policy Number:");
            int number = int.Parse(Console.ReadLine());

            if (!uniquePolicies.Add(number))
            {
                Console.WriteLine("Duplicate policy ignored");
                continue;
            }

            Console.WriteLine("Coverage Type:");
            string coverage = Console.ReadLine();

            Console.WriteLine("Expiry Date (yyyy-mm-dd):");
            DateTime expiry = DateTime.Parse(Console.ReadLine());

            Policy p = new Policy
            {
                PolicyNumber = number,
                CoverageType = coverage,
                ExpiryDate = expiry,
            };

            insertionOrder.Add(p);
            sortedByExpiry.Add(p);
        }

        Console.WriteLine("Policies expiring in next 30 days:");
        foreach (var p in sortedByExpiry)
        {
            if ((p.ExpiryDate - DateTime.Now).Days <= 30)
                Console.WriteLine(p.PolicyNumber);
        }
    }
}
