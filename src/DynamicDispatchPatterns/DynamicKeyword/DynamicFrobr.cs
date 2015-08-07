namespace DynamicDispatchPatterns.DynamicKeyword
{
    public class DynamicFrobr
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
            dynamic dynamicWidget = widget;
            this.FrobInternal(dynamicWidget);
        }

        private void FrobInternal(FooWidget dynamicWidget)
        {
            this.foo++;
        }

        private void FrobInternal(BarWidget dynamicWidget)
        {
            this.bar++;
        }

        private void FrobInternal(BazWidget dynamicWidget)
        {
            this.baz++;
        }

        private void FrobInternal(object dynamicWidget)
        {
            // No-op
        }
    }
}
