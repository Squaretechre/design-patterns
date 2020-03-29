package behavioral.visitor.withvisitor;

// ConcreteElement
public class Oil implements AtvPart {
    @Override
    public void accept(AtvPartVisitor visitor) {
        visitor.visit(this);
    }
}
