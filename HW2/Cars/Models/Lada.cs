namespace Cars;

class Lada : AMechanicalCar, IGas, IRadio
{
    protected override string Brand => "Lada";
    protected override int Seats => 2;
    protected override string InfoSystem => ((IRadio)this).InfoSystemName;

    public double EngineVolumeL => 1.6;

    protected override string EngineDescription => ((IGas)this).EngineDescription;
}
