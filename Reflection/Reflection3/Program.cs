class Program
{
    static void Main()
    {
        var sample = new Sample();

        MethodRunner.RunMethod(sample, "SayHello");
        MethodRunner.RunMethod(sample, "Greet", "Aakash");
    }
}
