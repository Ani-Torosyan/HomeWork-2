namespace HomeWork_2
{
    internal class Program
    {
        static void findMidElement(List<int> list)
        {
            int len = list.Count();
            if (len % 2 == 0) 
            {
                Console.WriteLine("The middle elements are: " + list[(len / 2) - 1] + " and " + list[(len / 2)]);
            }
            else Console.WriteLine("The middle element is: " +list[(len / 2)]);
        }
        static void Main(string[] args)
        {
            List<int> oddList = new List<int>() { 1, 2, 3};
            List<int> evenList = new List<int>() { 1, 2, 3, 4};

            findMidElement(oddList);  
            findMidElement(evenList);
        }
    }
}
