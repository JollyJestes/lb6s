public interface ICoffeeMachine
{
    string Model { get; set; }
    int YearOfManufacture { get; set; }
    bool IsAutomatic { get; set; }

    void BrewCoffee();
    void AddMilk();
    void AddSugar();
}