package structural.bridge.shapes.shape2;

public class Shape2BridgeDemo {

    public static void main(String[] args) {
        Shape square = new Square(new Blue());
        Shape circle = new Circle(new Red());
        Shape greenCircle = new Circle(new Green());

        square.applyColor();
        circle.applyColor();
        greenCircle.applyColor();
    }
}
