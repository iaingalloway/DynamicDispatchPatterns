namespace DynamicDispatchPatterns.TypeDelegateMap
{
    using System;
    using System.Collections.Generic;

    public class DelegateMapFrobr
    {
        private readonly IDictionary<Type, Action<object>> map;

        private int bar;

        private int baz;

        private int foo;

        public DelegateMapFrobr()
        {
            this.map = new Dictionary<Type, Action<object>>()
            {
                { typeof(FooWidget), this.OnFrobFoo },
                { typeof(BarWidget), this.OnFrobBar },
                { typeof(BazWidget), this.OnFrobBaz },
            };
        }

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

            if (this.map.ContainsKey(widgetType))
            {
                this.map[widgetType](widget);
            }
        }

        private void OnFrobBar(object x)
        {
            this.bar++;
        }

        private void OnFrobBaz(object x)
        {
            this.baz++;
        }

        private void OnFrobFoo(object x)
        {
            this.foo++;
        }
    }
}
