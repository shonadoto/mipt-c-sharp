namespace Cars;

class Toyota : AMechanicalCar, IGas, IAndroidAuto
{
    protected override string Brand => "Toyota";
    protected override int Seats => 4;
    protected override string InfoSystem => ((IAndroidAuto)this).InfoSystemName;

    public double EngineVolumeL => 2.0;

    protected override string EngineDescription => ((IGas)this).EngineDescription;
}
