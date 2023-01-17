namespace RpmMeter.Contracts
{
    public class Gear
    {
        private decimal gearRadius;
        private int gearInOrder;

        public decimal GearRadius
        {
            get
            {
                return gearRadius;
            }

            private set
            {
                gearRadius = value;
            }
        }

        public int GearInOrder
        {
            get
            {
                return gearInOrder;
            }

            set
            {
                gearInOrder = value;
            }
        }

    }
}