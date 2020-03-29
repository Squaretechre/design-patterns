package behavioral.visitor.withvisitor;

// ConcreteElement
public class Wheel implements AtvPart {
    @Override
    public void accept(AtvPartVisitor visitor) {
        visitor.visit(this);
    }
}
