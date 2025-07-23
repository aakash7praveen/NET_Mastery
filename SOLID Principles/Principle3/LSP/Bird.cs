namespace ManagementAPI._3
{
    public interface IBirdMethod
    {
        void Fly();
    }
    public class Bird
    {
        public string Name { get; set; }
    }

    public class Sparrow : Bird, IBirdMethod
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} the sparrow is flying!");
        }
    }

    public class Ostrich : Bird {

        //NO Fly Method
    }
}
