class Program
{
    static void Main(string[] args)
    {
        List<ICoffeeMachine> coffeeMachines = new List<ICoffeeMachine>
        {
            new EspressoMachine("ABC Brand"),
            
        };

        // Проверка на null перед выполнением операций
        foreach (var coffeeMachine in coffeeMachines)
        {
            if (coffeeMachine != null)
            {
                coffeeMachine.BrewCoffee();
                coffeeMachine.AddMilk();
                coffeeMachine.AddSugar();
                Console.WriteLine(coffeeMachine);
            }
        }

        // Добавление нового элемента после проверки на null
        ICoffeeMachine newMachine = new EspressoMachine("XYZ Brand");
        if (newMachine != null)
        {
            coffeeMachines.Add(newMachine);
        }

        // Редактирование элемента (пример редактирования первого элемента)
        if (coffeeMachines.Count > 0 && coffeeMachines[0] != null)
        {
            coffeeMachines[0] = new EspressoMachine("Updated Brand");
        }

        // Удаление случайного элемента из списка
        ICoffeeMachine removedMachine = null;
        if (coffeeMachines.Count > 0)
        {
            Random random = new Random();
            int indexToRemove = random.Next(coffeeMachines.Count);
            removedMachine = coffeeMachines[indexToRemove];
            coffeeMachines.RemoveAt(indexToRemove);
        }

        // Вывод информации о удаленном элементе
        if (removedMachine != null)
        {
            Console.WriteLine($"Removed Machine: {removedMachine}");
        }
        else
        {
            Console.WriteLine("No machine was removed.");
        }

        // Вывод обновленного содержимого списка с проверкой на null
        Console.WriteLine("\nUpdated List:");
        foreach (var coffeeMachine in coffeeMachines)
        {
            if (coffeeMachine != null)
            {
                coffeeMachine.BrewCoffee();
                coffeeMachine.AddMilk();
                coffeeMachine.AddSugar();
                Console.WriteLine(coffeeMachine);
            }
        }
    }
}