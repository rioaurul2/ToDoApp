using DesignPatternsPractice.Behavioral.Command.Exercises._1.Interfaces;

public class VolumeUpCommand : ICommandEx1
{
    private readonly Television _tv;

    public VolumeUpCommand(Television tv) => _tv = tv;

    public void Execute() => _tv.VolumeUp();
    public void Undo() => _tv.VolumeDown();
}
