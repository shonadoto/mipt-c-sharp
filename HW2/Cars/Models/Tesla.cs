namespace Cars;

class Tesla : AAutomaticCar, IElectric, IAndroidAuto
{
    protected override string Brand => "Tesla";
    protected override int Seats => 5;
    protected override string InfoSystem => ((IAndroidAuto)this).InfoSystemName;

    public int BatteryCapacityKwh => 75;

    protected override string EngineDescription => ((IElectric)this).EngineDescription;
}
