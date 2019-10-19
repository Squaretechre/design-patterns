namespace DesignPatterns.GangOfFour.Adapter
{
    public interface Shape
    {
        BoundingBox BoundingBox();
        Manipulator CreateManipulator();
    }
}