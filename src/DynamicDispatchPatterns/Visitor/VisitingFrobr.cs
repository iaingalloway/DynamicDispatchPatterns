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

        public void Frob(object widget)
        {
            var widgetType = widget.GetType();

            if (widgetType == typeof(FooWidget))
            {
                this.foo++;
            }
            else if (widgetType == typeof(BarWidget))
            {
                this.bar++;
            }
            else if (widgetType == typeof(BazWidget))
            {
                this.baz++;
            }
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
