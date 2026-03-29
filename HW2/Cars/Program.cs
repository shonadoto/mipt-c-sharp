using Cars;

while (true)
{
    Console.Write("Введите марку автомобиля или done для остановки ввода: ");
    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input) || input.Equals("done", StringComparison.OrdinalIgnoreCase))
        break;

    if (Enum.TryParse<CarType>(input, ignoreCase: true, out var carType))
    {
        var car = CarFactory.Create(carType);
        Console.WriteLine(car.GetDescription());
    }
    else
    {
        Console.WriteLine($"Марка \"{input}\" не найдена. Доступные марки: {string.Join(", ", Enum.GetNames<CarType>())}");
    }
}
