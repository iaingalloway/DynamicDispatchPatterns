namespace DynamicDispatchPatterns.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class ReflectingFrobr
    {
        private readonly IDictionary<Type, MethodInfo> cache =
            new Dictionary<Type, MethodInfo>();

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

        public void Frob(object widget)
        {
            var widgetType = widget.GetType();

            if (!this.cache.ContainsKey(widgetType))
            {
                var methodInfo = widgetType.GetMethod(
                    "Frob",
                    new[] { typeof(FrobContext) });

                this.cache.Add(widgetType, methodInfo);
            }

            if (this.cache[widgetType] == null)
            {
                return;
            }

            this.cache[widgetType].Invoke(widget, new object[] { this.context });
        }
    }
}
