namespace Cars;

abstract class ACar : ICar
{
    protected abstract string Brand { get; }
    protected abstract int Seats { get; }
    protected abstract string InfoSystem { get; }

    protected abstract string EngineDescription { get; }
    protected abstract string TransmissionDescription { get; }

    public virtual string GetDescription()
    {
        return $"{Brand}: {EngineDescription}, {TransmissionDescription}, " +
               $"{Seats} мест, {InfoSystem}";
    }
}
