namespace C06_PacktLibrary;

public interface IPlayable
{
    void Play();
    void Pause();

    void Stop()
    {
        WriteLine("Default implementaion of Stop.");
    }
}
