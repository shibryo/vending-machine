
using System.Linq;

public class Casher
{
    private List<Cash> deposit { get; set; }
    public Casher()
    {
        this.deposit = new List<Cash>();
    }
    public int insert(Cash cash)
    {
        this.deposit.Add(cash);
        return cash.GetQuantity();
    }
    public int total()
    {
        return this.deposit.Aggregate(0, (result, current) => result + current.GetQuantity());
    }
    public List<Cash> refund()
    {
        var refundDeposit = this.deposit;
        this.deposit.Clear();
        return refundDeposit;

    }
}