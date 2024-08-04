namespace ProblemSet1;
public class DoublyLinkedList
{
    public SinglyLinkedList Reverse(SinglyLinkedList list, int index, int k)
    {
        List<ListElement> elements = [];

        for (int i = 0; i < k; i++)
        {
            elements.Add(list.DeleteAt(index));
        }

        var arr = elements.ToArray();
        for (int i = k - 1; i >= 0; i--)
        {
            list.InsertAt(index, elements[i].Value);
        }
        return list;
    }
}
