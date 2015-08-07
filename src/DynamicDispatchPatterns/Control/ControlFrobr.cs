namespace DynamicDispatchPatterns.Control
{
    public class ControlFrobr
    {
        private int foo;

        public FrobResult Result
        {
            get
            {
                return new FrobResult()
                {
                    FooFrobCount = this.foo,
                    BarFrobCount = 0,
                    BazFrobCount = 0
                };
            }
        }

        public void Frob(object widget)
        {
            this.foo++;
        }
    }
}
