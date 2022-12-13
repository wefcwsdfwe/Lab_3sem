namespace SpaceBattle.Lib.Test;
public class MoveTests
{
    [Fact]
    public void MoveTestPositive()
    {
        // Arrange
        var a = new Mock<IMovable>();
        a.SetupGet(m => m.position).Returns(new Vector(12, 5)).Verifiable();

        a.SetupGet(m => m.velocity).Returns(new Vector(-7, 3)).Verifiable();

        var b = new MoveCommand(a.Object);

        // Act
        b.Execute();

        // Assert
        a.VerifySet(m => m.position = new Vector(5, 8));
    }

    [Fact]
    public void MoveWithoutPosition()
    {
        // Arrange
        var a = new Mock<IMovable>();
        a.SetupGet(m => m.position).Throws(new Exception());

        a.SetupGet(m => m.velocity).Returns(new Vector(-7, 3)).Verifiable();

        var b = new MoveCommand(a.Object);

        // Act
        // Assert
        Assert.Throws<Exception>(() => b.Execute());
    }

    [Fact]
    public void MoveWithoutVelocity()
    {
        // Arrange
        var a = new Mock<IMovable>();
        a.SetupGet(m => m.position).Returns(new Vector(12, 5)).Verifiable();

        a.SetupGet(m => m.velocity).Throws(new Exception());

        var b = new MoveCommand(a.Object);

        // Act
        // Assert
        Assert.Throws<Exception>(() => b.Execute());
    }

    [Fact]
    public void MoveBlocked()
    {
        // Arrange
        var a = new Mock<IMovable>();
        a.SetupGet(m => m.position).Returns(new Vector(12, 5)).Verifiable();

        a.SetupGet(m => m.velocity).Returns(new Vector(-7, 3)).Verifiable();

        a.SetupSet(m => m.position = It.IsAny<Vector>()).Throws(new Exception());

        var b = new MoveCommand(a.Object);

        // Act
        // Assert
        Assert.Throws<Exception>(() => b.Execute());
    }
}