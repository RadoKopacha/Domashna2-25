namespace CombinatingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Dai chisla: ");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = nums[nums.Count - 1];
            while (nums.Contains(number))
            {
                nums.Remove(number);
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}