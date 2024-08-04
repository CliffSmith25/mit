namespace intro_algorithms.test;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
        SinglyLinkedList _singlylinkedlist = new SinglyLinkedList([1, 2, 3, 4, 5, 6]);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
