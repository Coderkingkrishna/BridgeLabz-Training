class CustomHashMap
{
    private Answer[] table;
    private int size;

    public CustomHashMap(int size)
    {
        this.size = size;
        table = new Answer[size];
    }

    private int Hash(int key)
    {
        return key % size;
    }

    public void Put(int key, string value)
    {
        int index = Hash(key);

        while (table[index] != null && table[index].QuestionId != key)
        {
            index = (index + 1) % size;
        }

        table[index] = new Answer(key, value);
    }

    public Answer Get(int key)
    {
        int index = Hash(key);
        int startIndex = index;

        while (table[index] != null)
        {
            if (table[index].QuestionId == key)
                return table[index];

            index = (index + 1) % size;
            if (index == startIndex)
                break;
        }
        return null;
    }

    public Answer[] GetAll()
    {
        return table;
    }
}
