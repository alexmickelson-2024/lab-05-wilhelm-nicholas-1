using FluentAssertions;
using MainProgram;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void row1()
    {
        char[] board = new char[9] { 'X', 'X', 'X', 'd', 'e', 'f', 'g', 'h', 'i' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void row2()
    {
        char[] board = new char[9] { 'a', 'b', 'c', 'X', 'X', 'X', 'g', 'h', 'i' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void row3()
    {
        char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'X', 'X', 'X' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void vertical1()
    {
        char[] board = new char[9] { 'X', 'b', 'c', 'X', 'e', 'f', 'X', 'h', 'i' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void vertical2()
    {
        char[] board = new char[9] { 'a', 'X', 'c', 'd', 'X', 'f', 'g', 'X', 'i' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void vertical3()
    {
        char[] board = new char[9] { 'a', 'b', 'X', 'd', 'e', 'X', 'g', 'h', 'X' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void diagonal1()
    {
        char[] board = new char[9] { 'X', 'b', 'c', 'd', 'X', 'f', 'g', 'h', 'X' };
        Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void diagonal2()
    {
        char[] board = new char[9] { 'a', 'b', 'X', 'd', 'X', 'f', 'X', 'h', 'i' };
        Program.HasWinner(board).Should().Be(true);
    }
}