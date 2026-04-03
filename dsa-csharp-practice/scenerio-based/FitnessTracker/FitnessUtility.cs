using System;

class FitnessUtility : IFitness
{
    private Fitness[] fitnessData = new Fitness[20];
    private int count = 0;

    public void AddFitnessData()
    {
        if (count >= fitnessData.Length)
        {
            Console.WriteLine("Fitness data storage is full.");
            return;
        }

        Console.WriteLine("Person ID CREATED: " + (count + 1));
        Console.Write("Enter Steps: ");
        int steps = Convert.ToInt32(Console.ReadLine());

        fitnessData[count] = new Fitness(count + 1, steps);
        count++;
    }

    public void DisplayRankingOnSteps()
    {
        if (count == 0)
        {
            Console.WriteLine("No fitness data available.");
            return;
        }

        BubbleSort(fitnessData, count);

        Console.WriteLine("Fitness Data ranked by Steps:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(fitnessData[i] + " Rank: " + (i + 1));
        }
    }

    private void BubbleSort(Fitness[] data, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (data[j].StepsProperty < data[j + 1].StepsProperty)
                {
                    Fitness temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }
}
