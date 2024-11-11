public class Plants
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Plants(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void showDescription()
    {
        Console.WriteLine($"{Name}: ");
    }

    //Bagian Radit buat tanamannya
}