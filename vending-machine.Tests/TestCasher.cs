namespace vending_machine.Tests;
public class TestCasher
{
    [Fact]
    public void TestCasherの初期状態では合計が0である()
    {
        var casher = new Casher();

        Assert.Equal(0, casher.total());
    }
}