namespace DynamicDispatchPatterns.Polymorphic
{
    public class PolymorphicFrobr
    {
        private readonly FrobContext context = new FrobContext();

        public FrobResult Result
        {
            get
            {
                return new FrobResult()
                {
                    FooFrobCount = this.context.Foo,
                    BarFrobCount = this.context.Bar,
                    BazFrobCount = this.context.Baz
                };
            }
        }

        public void Frob(IWidget widget)
        {
            widget.Frob(this.context);
        }
    }
}
