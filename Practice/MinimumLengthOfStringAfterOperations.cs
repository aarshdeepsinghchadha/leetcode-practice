namespace Practice
{
    public class MinimumLengthOfStringAfterOperations
    {
        public void ProcessAndPrintMinimumLength()
        {
            string s1 = "abaacbcbb";
            string s2 = "aa";
            int output1 = MinimumLength(s1);
            int output2 = MinimumLength(s2);

            Console.WriteLine($"Input: {s1}, Output: {output1}");
            Console.WriteLine($"Input: {s2}, Output: {output2}");
        }
        private int MinimumLength(string s)
        {
            int[] charFrequency = new int[26];
            int totalLength = 0;
            foreach (char c in s)
            {
                charFrequency[c - 'a']++;
            }

            foreach (int frequency in charFrequency)
            {
                if (frequency == 0) continue;
                if (frequency % 2 == 0)
                {
                    totalLength += 2;
                }
                else
                {
                    totalLength += 1;
                }
            }

            return totalLength;

        }
    }
}
