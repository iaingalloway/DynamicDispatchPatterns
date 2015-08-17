namespace DynamicDispatchPatterns.Visitor
{
    public class VisitingFrobr : IWidgetVisitor
    {
        private int bar;

        private int baz;

        private int foo;

        public FrobResult Result
        {
            get
            {
                return new FrobResult()
                {
                    FooFrobCount = this.foo,
                    BarFrobCount = this.bar,
                    BazFrobCount = this.baz
                };
            }
        }

        public void Frob(IWidget widget)
        {
            widget.Accept(this);
        }

        public void Visit(FooWidget widget)
        {
            this.foo++;
        }

        public void Visit(BarWidget widget)
        {
            this.bar++;
        }

        public void Visit(BazWidget widget)
        {
            this.baz++;
        }
    }
}
