using ProblemSet1;

namespace ProblemSet1Test;

[TestFixture]
public class SinglyLinkedListTests
{
    [Test]
    public void BuildShouldBuildList()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        Assert.That(singlyLinkedList.GetLength(), Is.EqualTo(6), "List Length Should be Equal to 6");
    }

    [Test]
    public void GetAtShouldGetCorrectElement()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        Assert.That(singlyLinkedList.GetAt(3), Is.EqualTo(4), "List item 3 should be 4");
    }
    
    [Test]
    public void GetAtShouldReturnNullIfTooLarge()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        Assert.That(singlyLinkedList.GetAt(9), Is.EqualTo(null), "Too big should be null");
    }

    [Test]
    public void InsertAtShouldIncreaseLengthByOne()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        singlyLinkedList.InsertAt(2, 9);
        Assert.That(singlyLinkedList.GetLength(), Is.EqualTo(7), "After insert should be one bigger");
    }

    [Test]
    public void InsertAtShouldPlaceValueAtElement()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        singlyLinkedList.InsertAt(2, 9);
        Assert.That(singlyLinkedList.GetAt(2), Is.EqualTo(9), "Inserted element should be retrievable at position specified");
        singlyLinkedList.InsertAt(0, 9);
        Assert.That(singlyLinkedList.GetAt(0), Is.EqualTo(9), "First element insert should work correctly");
    }

    [Test]
    public void DeleteAtShouldDeleteAtElement()
    {
        SinglyLinkedList singlyLinkedList = new();
        singlyLinkedList.Build([1, 2, 3, 4, 5, 6]);
        singlyLinkedList.DeleteAt(0);
        Assert.That(singlyLinkedList.GetAt(0), Is.EqualTo(2), "Inserted element should be retrievable at position specified");
        singlyLinkedList.DeleteAt(3);
        Assert.That(singlyLinkedList.GetAt(3), Is.EqualTo(6), "First element insert should work correctly");
    }
}