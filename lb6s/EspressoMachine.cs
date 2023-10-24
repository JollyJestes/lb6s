public class EspressoMachine : CoffeeMachine
{
    public EspressoMachine(string brand) : base(brand)
    {
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
        return $"{base.ToString()} - Espresso Machine";
    }
}