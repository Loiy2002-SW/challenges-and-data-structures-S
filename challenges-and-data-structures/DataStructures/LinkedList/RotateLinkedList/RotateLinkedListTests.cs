using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
{

public class RotateLinkedListTests
{
    [Fact]
    public void RotateByZero_ShouldRemainUnchanged()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Act
        list.RotateLeft(0);

        // Assert
        Assert.Equal("1 -> 2 -> 3 -> 4 -> 5 -> Null", list.ToString());
    }

    [Fact]
    public void RotateByGreaterThanLength_ShouldWorkCorrectly()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Act
        list.RotateLeft(7); // List length is 5, so 7 % 5 = 2

        // Assert
        Assert.Equal("3 -> 4 -> 5 -> 1 -> 2 -> Null", list.ToString());
    }

    [Fact]
    public void RotateByExactLength_ShouldRemainUnchanged()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Act
        list.RotateLeft(5); // k == length

        // Assert
        Assert.Equal("1 -> 2 -> 3 -> 4 -> 5 -> Null", list.ToString());
    }

    [Fact]
    public void RotateListByK_ShouldReturnCorrectResult()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        // Act
        list.RotateLeft(3);

        // Assert
        Assert.Equal("40 -> 50 -> 10 -> 20 -> 30 -> Null", list.ToString());
    }
}

}
