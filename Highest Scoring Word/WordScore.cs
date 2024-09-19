namespace Highest_Scoring_Word
{
    internal class WordScore
    {
        public Dictionary<char, int> CharScoring { get; set; }
        public string Statement { get; set; }
        public WordScore(string words)
        {
            CharScoring = new()
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
            Statement = words;
        }

        public string GetMaxWord()
        {
            int maxSumWord = 0;
            string maxWord = string.Empty;
            foreach (string word in Statement.Split(' '))
            {
                int currentSum = GetWordCount(word);
                if (currentSum > maxSumWord)
                {
                    maxSumWord = currentSum;
                    maxWord = word;
                }
            }
            return maxWord;
        }
        
        public void PrintAllValues()
        {
            foreach (string word in Statement.Split(' '))
            {
                int currentSum = GetWordCount(word);
                Console.WriteLine($"Word:{word}\tCount:{currentSum}");
            }
        }

        public int GetWordCount(string word)
        {
            int currentSum = 0;
            foreach (char letter in word)
            {
                try
                {
                    currentSum += CharScoring[letter];
                }
                catch (Exception)
                {
                    Console.WriteLine($"WARNIGN- word:{word} has a char:{letter} with no score.");
                }
            }
            return currentSum;
        }
    }
}
