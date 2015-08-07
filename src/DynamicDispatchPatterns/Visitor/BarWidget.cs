namespace DynamicDispatchPatterns.Visitor
{
    public class BarWidget : IWidget
    {
        public void Accept(IWidgetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
