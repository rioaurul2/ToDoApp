public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU() => _computer.CPU = "Intel Core i9";
    public void SetGPU() => _computer.GPU = "NVIDIA RTX 4090";
    public void SetRAM() => _computer.RAM = 32;
    public void SetStorage() => _computer.Storage = 2000;
    public void SetOS() => _computer.OS = "Windows 11 Pro";
    public Computer GetComputer() => _computer;
}