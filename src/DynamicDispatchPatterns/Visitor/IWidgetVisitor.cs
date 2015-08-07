namespace DynamicDispatchPatterns.Visitor
{
    public interface IWidgetVisitor
    {
        void Visit(FooWidget widget);

        void Visit(BarWidget widget);

        void Visit(BazWidget widget);
    }
}
