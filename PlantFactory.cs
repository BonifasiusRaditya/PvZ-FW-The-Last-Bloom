class PlantFactory
{
    public static Plants CreatePlant(string plant)
    {
        switch (plant)
        {
            case "Sunflower":
                return new Plants("Sunflower", 10, 10, 1, 1, "Normal", "Sunflower");
            case "Peashooter":
                return new Plants("Peashooter", 10, 10, 1, 1, "Normal", "Sunflower");
            case "Wallnut":
                return new Plants("Wallnut", 10, 10, 1, 1, "Normal", "Sunflower");
            default:
                return new Plants("NULL", 0, 0, 0, 0, "Normal", "NULL");
        }
    }
}