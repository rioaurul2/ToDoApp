using DesignPatternsPractice.Behavioral.Command.Exercises._1.Interfaces;

public class TurnOffCommand : ICommandEx1
{
    private readonly Television _tv;

    public TurnOffCommand(Television tv) => _tv = tv;

    public void Execute() => _tv.TurnOff();
    public void Undo() => _tv.TurnOn();
}
