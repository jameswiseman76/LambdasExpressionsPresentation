/*
	1. So, we've seen our predicate delegate, but it's a bit specific. What if we wanted something more generic?

namespace ConsoleApp2
{
    public delegate bool MyDelegate(int a);

    public delegate bool MyPredicate<T>(T a);

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            list.Filter(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);
        }
    }

    public static class Extensions
    {
        public static IEnumerable<int> Filter(this List<int> list, MyPredicate<int> predicate)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}


	2. And isn't our Filter Function a bit specific? Yes.

namespace ConsoleApp2
{
    public delegate bool MyDelegate(int a);

    public delegate bool MyPredicate<T>(T a);

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            list.Filter(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);
        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this List<T> list, MyPredicate<T> predicate)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}


	3. One final modification…

    public delegate bool MyPredicate<in T>(T a);

This allows it to support contravariance. This then requires a further discussion about type safety, and directions of type compatibility that fall outside the scope of this discussion.

*/