class Program
{
    static void Main()
    {
        var user = new User
        {
            Id = 101,
            Name = "Aakash Praveen",
            Email = "aakash@example.com"
        };

        AttributeReader.PrintDisplayLabels(user);
    }
}
