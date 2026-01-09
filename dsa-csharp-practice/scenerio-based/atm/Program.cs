using System;

// Represents a currency note
class Note
{
    private int value;

    public int Value
    {
        get { return value; }
    }

    public Note(int value)
    {
        this.value = value;
    }
}

// ATM logic classes
class ATM
{
    private Note[] notes;

    public ATM(Note[] notes)
    {
        this.notes = notes;
        SortNotesDescending();
    }

    // Sort notes in descending order
    private void SortNotesDescending()
    {
        for (int i = 0; i < notes.Length - 1; i++)
        {
            for (int j = i + 1; j < notes.Length; j++)
            {
                if (notes[i].Value < notes[j].Value)
                {
                    var temp = notes[i];
                    notes[i] = notes[j];
                    notes[j] = temp;
                }
            }
        }
    }

    // Dispense money
    public void Dispense(int amount)
    {
        int remaining = amount;
        int[] count = new int[notes.Length];

        for (int i = 0; i < notes.Length; i++)
        {
            count[i] = remaining / notes[i].Value;
            remaining %= notes[i].Value;
        }

        if (remaining == 0)
        {
            Console.WriteLine("Dispensing " + amount);
            PrintResult(count);
        }
        else
        {
            Console.WriteLine("Exact change not possible for " + amount);
            Console.WriteLine("Fallback amount dispensed: " + (amount - remaining));
            PrintResult(count);
        }
    }

    private void PrintResult(int[] count)
    {
        for (int i = 0; i < notes.Length; i++)
        {
            if (count[i] > 0)
            {
                Console.WriteLine(notes[i].Value * count[i]);
            }
        }
        Console.WriteLine("-------------");
    }
}

class ATMTest
{
    static void Main()
    {
        // Scenario A
        Console.WriteLine("Scenario A: All Notes Available");
        Note[] notesA =
        {
            new Note(1),
            new Note(2),
            new Note(5),
            new Note(10),
            new Note(20),
            new Note(50),
            new Note(100),
            new Note(200),
            new Note(500),
        };

        ATM atmA = new ATM(notesA);
        atmA.Dispense(880);

        // Scenario B
        Console.WriteLine("Scenario B: ₹500 Removed");
        Note[] notesB =
        {
            new Note(1),
            new Note(2),
            new Note(5),
            new Note(10),
            new Note(20),
            new Note(50),
            new Note(100),
            new Note(200),
        };

        ATM atmB = new ATM(notesB);
        atmB.Dispense(880);

        // Scenario C
        Console.WriteLine("Scenario C: No Exact Change");
        Note[] notesC = { new Note(200), new Note(100), new Note(50) };

        ATM atmC = new ATM(notesC);
        atmC.Dispense(230);
    }
}
