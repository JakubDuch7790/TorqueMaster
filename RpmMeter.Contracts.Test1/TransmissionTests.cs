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
        Gear firstGear = new Gear(1, 750);
        Gear netralGear = new Gear(0, 0);

        transmission.Gears.AddFirst(firstGear);
        transmission.Gears.AddFirst(netralGear);
        transmission.CurrentGear = transmission.Gears.ElementAt(1);
        transmission.IsInNeutral = false;

        //Act

        transmission.ShiftIntoNeutral();

        //Assert
        Assert.True(transmission.IsInNeutral);
    }

}