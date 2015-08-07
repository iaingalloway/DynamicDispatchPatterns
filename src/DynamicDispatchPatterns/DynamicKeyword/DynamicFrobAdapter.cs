namespace DynamicDispatchPatterns.DynamicKeyword
{
    using System.Collections.Generic;

    public class DynamicFrobAdapter : IFrobAdapter
    {
        private readonly DynamicFrobr frobr = new DynamicFrobr();

        public FrobResult Frob(IEnumerable<WidgetType> widgets)
        {
            foreach (var widget in widgets)
            {
                switch (widget)
                {
                    case (WidgetType.Foo):
                        this.frobr.Frob(new FooWidget());
                        break;
                    case (WidgetType.Bar):
                        this.frobr.Frob(new BarWidget());
                        break;
                    case (WidgetType.Baz):
                        this.frobr.Frob(new BazWidget());
                        break;
                }
            }

            return this.frobr.Result;
        }
    }
}
