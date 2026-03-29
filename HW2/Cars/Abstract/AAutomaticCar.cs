namespace Cars;

abstract class AAutomaticCar : ACar, IAutomatic
{
    protected override string TransmissionDescription => ((IAutomatic)this).TransmissionType;
}
