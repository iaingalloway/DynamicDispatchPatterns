namespace DynamicDispatchPatterns.Polymorphic
{
    public class FooWidget : IWidget
    {
        public void Frob(FrobContext context)
        {
            context.Foo++;
        }
    }
}
