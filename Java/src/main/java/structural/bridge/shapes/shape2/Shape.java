package structural.bridge.shapes.shape2;

public abstract class Shape {

    protected final Color color;

    public Shape(Color color) {
        this.color = color;
    }

    abstract public void applyColor();
}
