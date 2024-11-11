class Program
{
    static void Main(string[] args)
    {
        Scientist Axel = Scientist.getInstance();
        Axel.AddPlant(Peashooter);
        Axel.AddItem(Sun);
    }
}