namespace Cars;

interface IElectric
{
    int BatteryCapacityKwh { get; }
    string EngineDescription => $"электрокар ({BatteryCapacityKwh} кВт·ч)";
}
