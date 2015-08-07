namespace DynamicDispatchPatterns.Polymorphic
{
    public class BarWidget : IWidget
    {
        public void Frob(FrobContext context)
        {
            context.Bar++;
        }
    }
}
