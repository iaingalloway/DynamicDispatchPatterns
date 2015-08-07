namespace DynamicDispatchPatterns.Control
{
    using System.Collections.Generic;

    public class ControlFrobAdapter : IFrobAdapter
    {
        private readonly ControlFrobr frobr = new ControlFrobr();

        public FrobResult Frob(IEnumerable<WidgetType> widgets)
        {
            foreach (var widget in widgets)
            {
                switch (widget)
                {
                    case (WidgetType.Foo):
                        this.frobr.Frob(new DynamicKeyword.FooWidget());
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
