namespace DynamicDispatchPatterns.Polymorphic
{
    public class BazWidget : IWidget
    {
        public void Frob(FrobContext context)
        {
            context.Baz++;
        }
    }
}
