namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "John", "Paul", "Hafiz", "Jacob", "Eve", "Cristina" };
          var name1 =  names.OrderBy(x => x.Length).ThenBy(x => x);
            var name2 = names.Where(x => x.Length > 3).ToList();
            var name3 = names.Where(x => x.Length == 3).ToList();
           foreach(string name in name3)
            {
                Console.WriteLine(name);
            }
        }
    }
}
