namespace DynamicDispatchPatterns.TypeSwitch
{
    public class TypeSwitchingFrobr
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
    }
}
