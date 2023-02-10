namespace RpmMeter.Contracts.Test1;

using RpmMeter.Contracts.Entities;

public class TransmissionTests
{
    /*[Fact]
    public void UpshiftGear_ShouldIncreaseGearByOneAndReturnNullIfItIsMaximumGear()
    {
        //  Arrange
        Transmission transmission = new Transmission();
        Gear expectedGear = transmission.CurrentGear;

        //  Act



        //  Assert
    }
    */
    [Fact]
    public void ShiftIntoNeutral_ShouldChangeproperiesInsideTranssmision()
    {
        // Arrange
        Transmission transmission = new();

        Gear firstGear = new Gear();
        firstGear.GearLabel = 1;

        Gear netralGear = new Gear();
        netralGear.GearLabel = 0;

        transmission.Gears.AddFirst(netralGear);
        transmission.Gears.AddLast(firstGear);

        transmission.CurrentGear = transmission.Gears.ElementAt(1);
        transmission.IsInNeutral = false;

        //Act

        transmission.ShiftIntoNeutral();

        //Assert
        Assert.True(transmission.IsInNeutral);
    }

}