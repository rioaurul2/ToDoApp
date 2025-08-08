using DesignPatternsPractice.Structural.Decorator.Exercises._2.Interface;

namespace DesignPatternsPractice.Structural.Decorator.Exercises._2.Decorator;

public abstract class SimpleTextDecoratorBase : IText
{
    protected IText _simpleText;

    protected SimpleTextDecoratorBase(IText simpleText)
    {
        _simpleText = simpleText;
    }

    public abstract string GetText();
}
