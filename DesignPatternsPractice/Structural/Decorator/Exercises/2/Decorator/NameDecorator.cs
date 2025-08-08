using DesignPatternsPractice.Structural.Decorator.Exercises._2.Interface;

namespace DesignPatternsPractice.Structural.Decorator.Exercises._2.Decorator;

public class NameDecorator : SimpleTextDecoratorBase
{
    public NameDecorator(IText text) : base(text) { }
    public override string GetText() => _simpleText.GetText() + "I'm Marin, ";
}
