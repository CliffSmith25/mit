using ProblemSet1;

namespace ProblemSet1Test;

[TestFixture]
public class DoublyLinkedListTests
{
    [Test]
    public void InitShouldInitList()
    {
        DoublyLinkedList list = new([1, 2, 3, 4, 5, 6, 7]);

        Assert.That(list.Tail(), Is.EqualTo(7), "List tail should be equal to 7");
        Assert.That(list.Head(), Is.EqualTo(1), "List head should be equal to 1");

        DoublyLinkedList singlelist = new([1]);
        Assert.That(singlelist.Tail(), Is.EqualTo(1));
        Assert.That(singlelist.Head(), Is.EqualTo(1));

        list = new([]);
        Assert.That(list.Head(), Is.EqualTo(null));
    }

    [Test]
    public void InsertFirstShouldInsert()
    {
        DoublyLinkedList list = new([1, 2, 3, 4, 5, 6, 7]);

        list.InsertFirst(22);
        list.InsertLast(44);

        Assert.That(list.Tail(), Is.EqualTo(44), "List tail should be equal to 44");
        Assert.That(list.Head(), Is.EqualTo(22), "List head should be equal to 22");
    }
}

