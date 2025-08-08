using DesignPatternsPractice.Structural.Decorator.Exercises._2.Interface;

namespace DesignPatternsPractice.Structural.Decorator.Exercises._2.Decorator;

public class FeelingDecorator : SimpleTextDecoratorBase
{
    public FeelingDecorator(IText text) : base(text) { }

    public override string GetText() => _simpleText.GetText() + "I feel sick, ";
}
