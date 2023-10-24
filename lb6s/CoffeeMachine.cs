public abstract class CoffeeMachine : ICoffeeMachine
{
    protected readonly string brand;

    protected CoffeeMachine(string brand)
    {
        this.brand = brand;
    }

    public abstract void BrewCoffee();
    public abstract void AddMilk();
    public abstract void AddSugar();

    public override string ToString()
    {
        return $"Coffee Machine: {brand}";
    }
}