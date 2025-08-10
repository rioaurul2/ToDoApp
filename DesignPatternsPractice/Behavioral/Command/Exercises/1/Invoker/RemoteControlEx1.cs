using DesignPatternsPractice.Behavioral.Command.Exercises._1.Interfaces;

public class RemoteControlEx1
{
    private ICommandEx1 _command;

    public void SetCommand(ICommandEx1 command) => _command = command;

    public void PressButton() => _command?.Execute();
    public void PressUndo() => _command?.Undo();
}
