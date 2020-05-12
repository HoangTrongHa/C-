namespace buoi2.GeometryExample
{
    public class Lion: Animal
    {
        public Lion( int weight,string name) : base( weight,name)
        {
        }

        public override void Show()
        {
            base.Show();
        }

        public override void SetMe(string name, int weight)
        {
            base.SetMe(name, weight);
        }
    }
}