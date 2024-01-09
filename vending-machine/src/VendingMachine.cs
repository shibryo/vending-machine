
public class VendingMachine
{
    private List<Money> deposit { get; set; }
    public VendingMachine()
    {
        this.deposit = new List<Money>();
    }
    public int insertMoney(Money money)
    {
        return 1;
    }
    public int totalMoney()
    {
        return 1;
    }
    public List<Money> refund()
    {
        var refundDeposit = this.deposit;
        this.deposit.Clear();
        return refundDeposit;

    }
}