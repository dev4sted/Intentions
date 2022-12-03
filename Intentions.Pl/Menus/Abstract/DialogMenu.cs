namespace Intentions.Pl.Menus.Abstract;

internal abstract class DialogMenu<TAnswer>
{
    private bool isClosed = false;

    public void Start()
    {
        while (!isClosed)
            ProcessAnswer(Ask());
    }

    protected abstract TAnswer Ask();

    protected abstract void ProcessAnswer(TAnswer answer);

    public void Stop() => isClosed = true;
}
