namespace Cars;

class BMW : AAutomaticCar, IGas, IAndroidAuto
{
    protected override string Brand => "BMW";
    protected override int Seats => 5;
    protected override string InfoSystem => ((IAndroidAuto)this).InfoSystemName;

    public double EngineVolumeL => 3.0;

    protected override string EngineDescription => ((IGas)this).EngineDescription;
}
