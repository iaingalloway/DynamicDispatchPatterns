namespace DynamicDispatchPatterns.Visitor
{
    public interface IWidget
    {
        void Accept(IWidgetVisitor visitor);
    }
}
