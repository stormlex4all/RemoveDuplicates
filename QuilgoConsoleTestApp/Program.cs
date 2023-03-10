namespace QuilgoConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberWithHighestOccurenceRate(new int[]{1,1,1,2,2,3,4,4,4,4,5,5,5,5 }));
        }

        static int[] RemoveDuplicates(int[] nums)
        {
            HashSet<int> distinct = new HashSet<int>();
            
            foreach (int n in nums)
            {
                distinct.Add(n);
            }

            int[] result = new int[distinct.Count];
            distinct.CopyTo(result);
            return result;
        }

        /// <summary>
        /// Gets the element of the integer array that has the highest number of occurrence 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int NumberWithHighestOccurenceRate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            IDictionary<int, int> numCount = new Dictionary<int, int>();
            int max = 0;
            int maxCount = 0;
            foreach (int n in nums)
            {
                if (numCount.ContainsKey(n))
                {
                    numCount[n] = numCount[n] + 1;
                }
                else
                {
                    numCount[n] = 1;
                }
            }

            foreach(KeyValuePair<int, int> pair in numCount)
            {
                if (maxCount < pair.Value)
                {
                    maxCount = pair.Value;
                    max = pair.Key;
                }
            }
            return max;
        }
    }
}