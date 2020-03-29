namespace DesignPatterns.GangOfFour.Adapter
{
    public class Line : Shape
    {
        public BoundingBox BoundingBox()
        {
            return new BoundingBox();
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator();
        }
    }
}
