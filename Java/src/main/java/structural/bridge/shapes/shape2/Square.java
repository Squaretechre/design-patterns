package structural.bridge.shapes.shape2;

public class Square extends Shape {

    public Square(Color color) {
        super(color);
    }

    @Override
    public void applyColor() {
       color.applyColor();
    }
}
