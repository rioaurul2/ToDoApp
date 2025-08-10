using DesignPatternsPractice.Behavioral.Command.Exercises._1.Interfaces;

public class TurnOnCommand : ICommandEx1
{
    private readonly Television _tv;

    public TurnOnCommand(Television tv) => _tv = tv;

    public void Execute() => _tv.TurnOn();
    public void Undo() => _tv.TurnOff();
}
