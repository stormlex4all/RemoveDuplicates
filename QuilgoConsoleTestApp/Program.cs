namespace QuilgoConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates(new int[]{1,1,2,2,3,4,5,5 }));
            Console.ReadLine();
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
    }
}