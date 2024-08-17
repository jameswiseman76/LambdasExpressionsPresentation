/*
//We use the word delegate here in place of 'function' here which we might expect in other languages

//We still define an explicit 'type' C# is strongly-typed and type-safe, so the signaure has a clear definition.

        delegate int MyDelegate(int a, int b);


        static void Main(string[] args)
        {
            var x = RunDelegate(delegate (int a, int b) { return a + b; }, 1, 2);
        }


        static int RunDelegate(MyDelegate myDelegate, int a, int b)
        {
            return myDelegate(a, b);
        }

*/