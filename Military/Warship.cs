namespace Military
{
    public class Warship : Vehicle
    {
        public Warship(int id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 30, 6)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
