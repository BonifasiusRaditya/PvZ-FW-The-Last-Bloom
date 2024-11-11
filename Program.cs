class Program
{
    static void Main(string[] args)
    {
        Scientist Axel = Scientist.GetInstance();

        Plants peashooter = new Plants("Peashooter", "Shooter");
        Items sun = new Items("Sun", Items.ItemType.SingleUse);
        Axel.AddPlant(peashooter);
        Axel.AddItem(sun);

        Axel.ShowInventory();
    }
}
