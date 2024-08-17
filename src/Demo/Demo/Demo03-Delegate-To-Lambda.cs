/*
//But we don't need the word 'delegate' we could just remove it and add our lambda symbol like so

        static void Main(string[] args)
        {
            var x = RunDelegate((int a, int b) => { return a + b; }, 1, 2);
        }

//But this is also just longhand, we don't need the variable types:

        static void Main(string[] args)
        {
            var x = RunDelegate((a, b) => { return a + b; }, 1, 2);
        }

//What's going  on here?

//Well, one of C#s killer features is it's type inference. C# can infer from the delegate type what all the types are

//Can we go any further? Well, yes, because 'return' is actually redundant ( most of the time)

        static void Main(string[] args)
        {
            var x = RunDelegate((a, b) => a + b, 1, 2);
        }



*/