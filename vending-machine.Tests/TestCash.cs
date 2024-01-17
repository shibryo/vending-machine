namespace vending_machine.Tests;
public class TestCash
{
    [Fact]
    public void TestCashが500のときGetQuantityは500になる()
    {
        var cash = new Cash(500);

        Assert.Equal(500, cash.GetQuantity());
    }
}