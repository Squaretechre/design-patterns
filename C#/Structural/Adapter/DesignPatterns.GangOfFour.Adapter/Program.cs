using System;

namespace DesignPatterns.GangOfFour.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextView does not implement the Shape interface
            var textView = new TextView();

            Shape textShape = new TextShape(textView);
            Shape line = new Line();

            var drawingEditor = new DrawingEditor();

            drawingEditor.Draw(line);
            drawingEditor.Draw(textShape);
        }
    }
}
