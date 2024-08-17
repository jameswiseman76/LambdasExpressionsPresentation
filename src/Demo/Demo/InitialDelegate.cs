internal class Program2
{
    delegate int MyDelegate(int a, int b);


    static void Main2(string[] args)
    {
        var x = RunDelegate(Add, 1, 2);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int RunDelegate(MyDelegate myDelegate, int a, int b)
    {
        return myDelegate(a, b);
    }
}