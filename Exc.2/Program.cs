namespace HomeWork_2
{
    internal class Program
    {
        static int findMax(List<int> list)
        {
            int max = list[0];
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int max = findMax(list);

            Console.WriteLine("The largest element in the list is: " + max);
        }
    }
}
