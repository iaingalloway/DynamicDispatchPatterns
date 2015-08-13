namespace DynamicDispatchPatterns.TypeDelegateArray
{
    using System;
    using System.Collections.Generic;

    public class DelegateArrayFrobr
    {
        private readonly KeyValuePair<Type, Action<object>>[] map;

        private int bar;

        private int baz;

        private int foo;

        public DelegateArrayFrobr()
        {
            this.map = new []
            {
                new KeyValuePair<Type, Action<object>>(typeof(FooWidget), this.OnFrobFoo),
                new KeyValuePair<Type, Action<object>>(typeof(BarWidget), this.OnFrobBar),
                new KeyValuePair<Type, Action<object>>(typeof(BazWidget), this.OnFrobBaz)
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

            for (var i = 0; i < map.Length; i++)
            {
                if (map[i].Key == widgetType)
                {
                    map[i].Value(widget);
                    return;
                }
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
