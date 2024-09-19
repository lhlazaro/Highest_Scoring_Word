using Highest_Scoring_Word;

internal class Program
{
    public static Dictionary<char, int> alphabet = new()
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11 },
            { 'l', 12 },
            { 'm', 13 },
            { 'n', 14 },
            { 'o', 15 },
            { 'p', 16 },
            { 'q', 17 },
            { 'r', 18 },
            { 's', 19 },
            { 't', 20 },
            { 'u', 21 },
            { 'v', 22 },
            { 'w', 23 },
            { 'x', 24 },
            { 'y', 25 },
            { 'z', 26 }
        };
    private static void Main(string[] args)
    {
        string words = "luis angel hernandez1 hernandez2 lazaro aaa zzz abc abad zzzaq qazzz";
        Console.WriteLine(GetMaxCountLetter(words));
        Console.WriteLine("==========================================");
        WordScore wordScore = new(words);
        Console.WriteLine("MaxWord:"+ wordScore.GetMaxWord());
        Console.WriteLine("==========================================");
        wordScore.PrintAllValues();
    }

    public static string GetMaxCountLetter(string words)
    {
        int maxSumWord = 0;
        string maxWord = string.Empty;
        foreach (string word in words.Split(' '))
        {
            int currentSum = 0;
            foreach (char letter in word)
            {
                try
                {
                    currentSum += alphabet[letter];
                }
                catch (Exception e)
                {
                    Console.WriteLine($"char:{letter} has no score.");
                }
            }
            if (currentSum > maxSumWord)
            {
                maxSumWord = currentSum;
                maxWord = word;
            }
        }
        return maxWord;
    }
}