public interface ISubjectEx1
{
    void Attach(IObserverEx1 observer);
    void Detach(IObserverEx1 observer);
    void Notify(string news);
}
