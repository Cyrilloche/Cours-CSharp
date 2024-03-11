internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = [10, 20, 30, 40];
        DisplayList(list);

        System.Console.WriteLine();

        IEnumerable<int> newList = Fonction(list, x => x-5);
        DisplayList(newList);

        Console.ReadLine();
        

        static IEnumerable<int> Fonction(List<int> list,  Func<int, int> func)
        {
            IEnumerable<int> newList = list.Select(func);
            return newList;
        }

        static void DisplayList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}