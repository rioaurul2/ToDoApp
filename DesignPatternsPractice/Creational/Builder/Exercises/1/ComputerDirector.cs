public class ComputerDirector
{
    private readonly IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void BuildComputer()
    {
        _builder.SetCPU();
        _builder.SetGPU();
        _builder.SetRAM();
        _builder.SetStorage();
        _builder.SetOS();
    }

    public Computer GetComputer() => _builder.GetComputer();
}
