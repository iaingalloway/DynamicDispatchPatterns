namespace DynamicDispatchPatterns.Console
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using DynamicDispatchPatterns.Control;
    using DynamicDispatchPatterns.DynamicKeyword;
    using DynamicDispatchPatterns.Polymorphic;
    using DynamicDispatchPatterns.Reflection;
    using DynamicDispatchPatterns.TypeDelegateArray;
    using DynamicDispatchPatterns.TypeDelegateMap;
    using DynamicDispatchPatterns.TypeSwitch;
    using DynamicDispatchPatterns.Visitor;
    using ShuffleBag;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var iterations = 10000000;

            var frobrs =
                new IFrobAdapter[]
                {
                    new ControlFrobAdapter(),
                    new DynamicFrobAdapter(),
                    new PolymorphicFrobAdapter(),
                    new ReflectingFrobAdapter(),
                    new DelegateMapFrobAdapter(),
                    new DelegateArrayFrobAdapter(), 
                    new TypeSwitchingFrobAdapter(),
                    new VisitingFrobAdapter(),
                }.ShuffleInfinitely().Take(35);

            var widgetTypes =
                Enum.GetValues(typeof(WidgetType)).Cast<WidgetType>();

            var widgetSequence =
                Enumerable.Range(0, 10)
                          .SelectMany(x => widgetTypes)
                          .ShuffleInfinitely()
                          .Take(iterations)
                          .ToArray();

            var stopwatch = new Stopwatch();
            foreach (var frobr in frobrs)
            {
                stopwatch.Start();
                frobr.Frob(widgetSequence);
                stopwatch.Stop();

                Console.WriteLine(
                    "{0} took {1} ms to frob {2} widgets.",
                    frobr.GetType().Name,
                    stopwatch.ElapsedMilliseconds,
                    iterations);

                stopwatch.Reset();
            }

            Console.WriteLine("Done. Press any key to close.");

            Console.ReadKey();
        }
    }
}
