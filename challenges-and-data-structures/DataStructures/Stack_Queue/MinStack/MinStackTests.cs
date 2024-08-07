using challenges_and_data_structures.DataStructures.Stack_Queue.MinStack;

public class MinStackTests
{
    [Fact]
    public void TestPushAndMin()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(3);
        minStack.Push(7);
        Assert.Equal(3, minStack.GetMin());
    }

    [Fact]
    public void TestPopAndMin()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(3);
        minStack.Push(7);
        minStack.Pop();
        Assert.Equal(3, minStack.GetMin());
        minStack.Pop();
        Assert.Equal(5, minStack.GetMin());
    }

    [Fact]
    public void TestTop()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(3);
        minStack.Push(7);
        Assert.Equal(7, minStack.Peek());
    }

    [Fact]
    public void TestIsEmpty()
    {
        MinStack minStack = new MinStack();
        Assert.True(minStack.IsEmpty());
        minStack.Push(5);
        Assert.False(minStack.IsEmpty());
    }

    [Fact]
    public void TestGetMin()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(3);
        minStack.Push(7);
        Assert.Equal(3, minStack.GetMin());
    }

    [Fact]
    public void TestPrintStack()
    {
        MinStack minStack = new MinStack();
        minStack.Push(5);
        minStack.Push(3);
        minStack.Push(7);
        // We won't assert on PrintStack as it prints to the console, 
        // but you can manually verify the output when running the tests.
        minStack.PrintStack();
    }
}
