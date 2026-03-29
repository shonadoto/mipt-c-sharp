namespace Cars;

abstract class AMechanicalCar : ACar, IMechanical
{
    protected override string TransmissionDescription => ((IMechanical)this).TransmissionType;
}
