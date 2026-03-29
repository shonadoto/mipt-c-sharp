namespace Cars;

interface IGas
{
    double EngineVolumeL { get; }
    string EngineDescription => $"бензиновый двигатель ({EngineVolumeL} л)";
}
