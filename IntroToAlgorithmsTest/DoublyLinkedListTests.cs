using ProblemSet1;

namespace ProblemSet1Test;

[TestFixture]
public class DoublyLinkedListTests
{
    [Test]
    public void ReverseShouldReverseList()
    {
        SinglyLinkedList list = new SinglyLinkedList();
        list.Build([1, 2, 3, 4, 5, 6, 7, 8, 9]);
        DoublyLinkedList doublyLinkedList = new();

        SinglyLinkedList newList = doublyLinkedList.Reverse(list, 2, 4);

        SinglyLinkedList testList = new SinglyLinkedList();
        list.Build([1, 2, 3, 7, 6, 5, 4, 8, 9]);
        Assert.That(newList, Is.EqualTo(testList), "Reversing should reverse the list correctly");
    }
}