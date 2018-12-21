namespace Military
{
    public class Amfibia : Vehicle
    {
        public Amfibia(int id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 30, 6)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
