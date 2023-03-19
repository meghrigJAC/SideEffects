namespace SideEffects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 6, 4, 3, 1, 7, 2, 10 };

            //Getting the 3 least numbers
            List<int> smallests = GetSmallests(numbers, 3);

            PrintList("Smallest List:", smallests);
        }

        static List<int> GetSmallests(List<int> list, int count)
        {
            List<int> smallests = new List<int>();

            while (smallests.Count < count)
            {
                int min = GetSmallestElement(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;

        }

         static int GetSmallestElement(List<int> list)
        {
            //Assuming the first element is the smallest
            var min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
        static void PrintList(string listName, List<int> list)
        {
            Console.WriteLine(listName);
            foreach (int number in list)
                Console.WriteLine(number);

        }
    }
}