namespace ProblemSet1;

public class DoublyLinkedList
{
    private ListElement? _head { get; set; }
    private ListElement? _tail { get; set; }

    public DoublyLinkedList(int[] seed)
    {
        if (seed.Length == 0)
        {
            _head = null;
            _tail = null;
            return;
        }

        ListElement lastElem = new();
        ListElement currElem = new();
        ListElement nextElem = new();

        for (int i = 0; i < seed.Length; i++)
        {
            lastElem = currElem;

            if (nextElem is null)
            {
                currElem = new();
                currElem.PrevElement = lastElem;
            }
            else
            {
                currElem = nextElem;
            }

            currElem.Value = seed[i];

            if (i < seed.Length - 1)
            {
                nextElem = new();
                nextElem.Value = seed[i + 1];
            }
            else
            {
                nextElem = new();
            }

            currElem.NextElement = nextElem;

            if (i == 0)
            {
                _head = currElem;
            }

            if (i == seed.Length - 1)
            {
                _tail = currElem;
            }
        }
    }

    public void InsertFirst(int n)
    {
        ListElement elem = new();

        elem.Value = n;
        elem.NextElement = _head;

        _head.PrevElement = elem;

        _head = elem;
    }

    public void InsertLast(int n)
    {
        ListElement elem = new();
        elem.Value = n;
        elem.PrevElement = _tail;

        _tail.NextElement = elem;
        _tail = elem;
    }

    public int Tail()
    {
        return _tail.Value;
    }

    public int Head()
    {
        return _head.Value;
    }
}
