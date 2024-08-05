namespace ProblemSet1;

public class SinglyLinkedList
{
    private ListElement _firstElement;

    private int _length = 0;

    public void Build(int[] list)
    {
        ListElement prevElement = new();
        for (int i = list.Length - 1; i >= 0; i--)
        {
            ListElement listElement = new();
            listElement.Value = list[i];

            listElement.NextElement = prevElement;

            prevElement = listElement;
            _length++;
        }
        _firstElement = prevElement;
    }

    public int GetLength()
    {
        return _length;
    }

    public int InsertAt(int index, int value)
    {
        if (index < 0 || index > _length)
        {
            return -1;
        }

        ListElement newElement = new();
        newElement.Value = value;

        if (index == 0)
        {
            newElement.NextElement = _firstElement;
            _firstElement = newElement;
        }
        else
        {
            int pos = 1;
            ListElement prevElement = _firstElement;
            var curElement = _firstElement.NextElement;
            while (pos < index)
            {
                prevElement = curElement;
                curElement = curElement.NextElement;
                pos++;
            }

            newElement.NextElement = prevElement.NextElement;
            prevElement.NextElement = newElement;
        }

        _length++;
        return _length;
    }

    public ListElement? DeleteAt(int index)
    {
        if (index < 0 || index >= _length - 1)
        {
            return null;
        }

        ListElement deletedElement = new();
        if (index == 0)
        {
            deletedElement = _firstElement;
            _firstElement = _firstElement.NextElement;
        }
        else
        {
            int pos = 1;
            ListElement prevElement = _firstElement;
            while (pos < index)
            {
                prevElement = prevElement.NextElement;
                pos++;
            }

            deletedElement = prevElement.NextElement;
            prevElement.NextElement = deletedElement.NextElement;
        }
        _length--;
        return deletedElement;
    }

    public void Reverse(int index, int k)
    {
        List<ListElement> elements = [];

        for (int i = 0; i < k; i++)
        {
            elements.Add(DeleteAt(index));
        }

        var arr = elements.ToArray();
        for (int i = 0; i < k; i++)
        {
            InsertAt(index, elements[i].Value);
        }
    }

    public void Move(int index, int k, int j)
    {
        List<ListElement> elements = [];

        for (int i = 0; i < k; i++)
        {
            elements.Add(DeleteAt(index));
        }

        int newIndex = j;
        if (j > index)
        {
            newIndex = j - k;
        }

        var arr = elements.ToArray();
        for (int i = k - 1; i >= 0; i--)
        {
            InsertAt(newIndex, elements[i].Value);
        }
    }

    public int? GetAt(int i)
    {
        if (i > _length - 1)
        {
            return null;
        }

        int pos = 0;
        var curElement = _firstElement;
        while (pos < i)
        {
            curElement = curElement.NextElement;
            pos++;
        }

        return curElement.Value;
    }
}

public class ListElement
{
    public int Value { get; set; }
    public ListElement? NextElement { get; set; }
    public ListElement? PrevElement { get; set; }
}
