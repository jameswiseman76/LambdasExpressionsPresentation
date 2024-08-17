/*

using System.Linq.Expressions;
using System.Collections;
using System.Reflection;

namespace ConsoleApp
{
    public delegate bool MyDelegate(int a);
    public delegate bool MyPredicate<in T>(T a);

    public delegate void MyAction<in T>(T a);
    public delegate void MyAction<in T1, in T2>(T1 a, T2 b);

    public delegate TOut MyFunc<in T, out TOut>(T a);


    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var employeeList = new List<Employee>();
            employeeList.SQLFilter(
                BusinessRulesExpressions.IsEmployeeOlderThan100.AndAlso(BusinessRulesExpressions.IsManager));
        }
    }

    public static class Extensions
    {
        public static void SQLFilter<T>(this List<T> list, Expression<Func<T, bool>> predicate)
        {
            var parameters = predicate.Parameters;
            Console.WriteLine(parameters[0].Name);
            Console.WriteLine(parameters[0].Type.Name);

            var body = predicate.Body as BinaryExpression;
            var left = body.Left as MemberExpression;
            Console.WriteLine(left.Member.Name);
            Console.WriteLine(left.Expression);
            Console.WriteLine(left.Expression.Type);
            Console.WriteLine(body.NodeType);
            Console.WriteLine(body.Right);

            var sqlQuery = $"SELECT * FROM {parameters[0].Type.Name} Where {left.Member.Name} {body.NodeType.ToSqlOperator()} {body.Right}";
            Console.WriteLine(sqlQuery);
        }
    }

    public static class BusinessRulesExpressions
    {
        //Is employee older than 100 years
        public static Expression<Func<Employee, bool>> IsEmployeeOlderThan100
        {
            get => x => x.Age > 100;
        }

        // is a manager
        public static Expression<Func<Employee, bool>> IsManager
        {
            get => x => x.JobRole == JobRole.Manager;
        }

    }

    // convert nodetype to sql operator
    public static class NodeTypeToSqlOperator
    {
        public static string ToSqlOperator(this ExpressionType nodeType)
        {
            switch (nodeType)
            {
                case ExpressionType.Equal:
                    return "=";
                case ExpressionType.NotEqual:
                    return "<>";
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                default:
                    throw new NotSupportedException();
            }
        }
    }

    public enum JobType
    {
        FullTime,
        PartTime,
        Contract
    }

    public enum JobRole
    {
        Developer,
        Tester,
        Manager
    }

    public class Employee
    {
        public string Name { get; set; }

        public JobType JobType { get; set; }

        public JobRole JobRole { get; set; }

        public int Age { get; set; }
    }


    public static class PredicateExtensions
    {
        public static Expression<Func<T, bool>> AndAlso<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            var parameter = Expression.Parameter(typeof(T));

            var combined = new ReplaceParameterVisitor
            {
                { first.Parameters[0], parameter },
                { second.Parameters[0], parameter }
            }.Visit(Expression.AndAlso(first.Body, second.Body));

            return Expression.Lambda<Func<T, bool>>(combined, parameter);
        }

        private class ReplaceParameterVisitor : ExpressionVisitor, IEnumerable<KeyValuePair<ParameterExpression, ParameterExpression>>
        {
            private readonly Dictionary<ParameterExpression, ParameterExpression> _map = new Dictionary<ParameterExpression, ParameterExpression>();

            public void Add(ParameterExpression from, ParameterExpression to)
            {
                _map[from] = to;
            }

            public IEnumerator<KeyValuePair<ParameterExpression, ParameterExpression>> GetEnumerator()
            {
                return _map.GetEnumerator();
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                if (_map.TryGetValue(node, out var replacement))
                {
                    node = replacement;
                }
                return base.VisitParameter(node);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}


 */
