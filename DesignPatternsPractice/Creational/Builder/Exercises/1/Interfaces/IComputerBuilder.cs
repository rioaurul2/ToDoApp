public interface IComputerBuilder
{
    void SetCPU();
    void SetGPU();
    void SetRAM();
    void SetStorage();
    void SetOS();
    Computer GetComputer();
}
