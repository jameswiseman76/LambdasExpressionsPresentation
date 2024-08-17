/*

/*

using System.Linq.Expressions;

namespace ConsoleApp2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            list.OutputExpression(x => x % 2 == 0);
        }
    }

    public static class Extensions
    {
        public static void OutputExpression<T>(this List<T> list, Expression<Func<T, bool>> predicate)
        {
            var parameters = predicate.Parameters;
            Console.WriteLine(parameters[0].Name);
            Console.WriteLine(parameters[0].Type);

            var body = predicate.Body as BinaryExpression;
            Console.WriteLine(body.Left);
            Console.WriteLine(body.NodeType);
            Console.WriteLine(body.Right);
        }
    }
}

We can pick apart the expressions now. 

x => x % 2 == 0 becomes  a data structure that we can pick information off.

We can get the details of the parameters, and this function a lot like reflection at this stage. The interesting information here is really in the body.

Everything an type of 'System.Expression' so here to demonstrate we cast to the sort of expression we know that it is, namely a BinaryExpressions.

We can then get details about the expression itself… 
It has a left, a right and a node type.

So, how is this useful



C# (6???) introduced a (nameof) keyword


 */
