namespace Military
{
    public class Tank : Vehicle 
    {
        public Tank(int id, double weight, double averageSpeed)
        : base(id,weight,averageSpeed,30,6)
        {
            
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
