namespace DesignPatterns.GangOfFour.Adapter
{
    public class TextShape : Shape
    {
        private readonly TextView _textView;

        public TextShape(TextView textView)
        {
            _textView = textView;
        }

        public BoundingBox BoundingBox()
        {
            return _textView.GetExtent();
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator();
        }
    }
}
