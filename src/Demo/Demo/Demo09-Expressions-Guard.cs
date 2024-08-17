/*

    public static class Guard
    {
        public static void NotNull<T>(Expression<Func<T>> variable)
        {
            var func = variable.Compile();
            var variableValue = func();
            var variableName = ((MemberExpression)variable.Body).Member.Name;
            if (variableValue is null)
            {
                throw new ArgumentNullException($"{variableName}");
            }
        }
    }


 */