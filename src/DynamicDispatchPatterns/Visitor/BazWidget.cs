namespace DynamicDispatchPatterns.Visitor
{
    public class BazWidget : IWidget
    {
        public void Accept(IWidgetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
