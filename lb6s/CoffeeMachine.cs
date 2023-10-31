public abstract class CoffeeMachine : ICoffeeMachine
{
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }
    public bool IsAutomatic { get; set; }

    protected CoffeeMachine(string model, int yearOfManufacture, bool isAutomatic)
    {
        Model = model;
        YearOfManufacture = yearOfManufacture;
        IsAutomatic = isAutomatic;
    }

    public abstract void BrewCoffee();
    public abstract void AddMilk();
    public abstract void AddSugar();

    public override string ToString()
    {
        return $"Coffee Machine: {Model}, Year: {YearOfManufacture}, Automatic: {IsAutomatic}";
    }
}