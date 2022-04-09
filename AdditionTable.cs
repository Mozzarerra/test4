class AdditionTable
{
    public static void PrintList()
    {
        List<string> additionTableList = new List<string>();
        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                additionTableList.Add($"{a} + {b} = {a + b}");
            }
        }
        foreach (string line in additionTableList)
        {
            Console.WriteLine(line);
        }
    }
}
