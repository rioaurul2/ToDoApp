public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU() => _computer.CPU = "Intel Core i5";
    public void SetGPU() => _computer.GPU = "Integrated Graphics";
    public void SetRAM() => _computer.RAM = 16;
    public void SetStorage() => _computer.Storage = 512;
    public void SetOS() => _computer.OS = "Windows 11 Home";
    public Computer GetComputer() => _computer;
}