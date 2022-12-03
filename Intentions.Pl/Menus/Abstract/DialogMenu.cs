namespace Intentions.Pl.Menus.Abstract;

internal abstract class DialogMenu<TAnswer>
{
    public void Start()
    {
        bool isClosed = false;

        while (!isClosed)
            isClosed = ProcessAnswer(Ask());
    }

    protected abstract TAnswer Ask();

    protected abstract bool ProcessAnswer(TAnswer answer);
}
