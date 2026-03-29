namespace Cars;

static class CarFactory
{
    public static ICar Create(CarType type) => type switch
    {
        CarType.Tesla => new Tesla(),
        CarType.BMW => new BMW(),
        CarType.Toyota => new Toyota(),
        CarType.Lada => new Lada(),
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Неизвестный тип: {type}")
    };
}
