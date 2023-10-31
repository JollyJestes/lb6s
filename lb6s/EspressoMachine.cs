public class EspressoMachine : CoffeeMachine
{
    public int WaterCapacity { get; set; }
    public int MilkCapacity { get; set; }
    public int SugarCapacity { get; set; }

    public EspressoMachine(string model, int yearOfManufacture, bool isAutomatic, int waterCapacity, int milkCapacity, int sugarCapacity)
        : base(model, yearOfManufacture, isAutomatic)
    {
        WaterCapacity = waterCapacity;
        MilkCapacity = milkCapacity;
        SugarCapacity = sugarCapacity;
    }

    public override void BrewCoffee()
    {
        Console.WriteLine("Brewing Espresso");
    }

    public override void AddMilk()
    {
        Console.WriteLine("Adding steamed milk");
    }

    public override void AddSugar()
    {
        Console.WriteLine("Adding sugar");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Water Capacity: {WaterCapacity}, Milk Capacity: {MilkCapacity}, Sugar Capacity: {SugarCapacity}";
    }
}