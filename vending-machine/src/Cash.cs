
public class Cash
{
    public Cash(int quantity)
    {
        this._quantity = quantity;
    }
    public int GetQuantity()
    {
        return this._quantity;
    }
    private int _quantity { get; set; }
}