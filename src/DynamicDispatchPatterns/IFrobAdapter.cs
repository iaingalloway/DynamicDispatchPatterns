namespace DynamicDispatchPatterns
{
    using System.Collections.Generic;

    public interface IFrobAdapter
    {
        FrobResult Frob(IEnumerable<WidgetType> widgets);
    }
}
