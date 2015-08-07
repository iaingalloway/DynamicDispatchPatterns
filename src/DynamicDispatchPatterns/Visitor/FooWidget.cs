namespace DynamicDispatchPatterns.Visitor
{
    public class FooWidget : IWidget
    {
        public void Accept(IWidgetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
