namespace OOP.Aggregation;

class VendingMachine
{
    private Product[] _productShelf;
    private int _capacity;
    private static int _productCount;

    public VendingMachine()
    {
        this._productShelf = new Product[5];
        this._capacity = 5;
        _productCount = 0;
    }

    public bool InsertProdcut(Product item)
    {
        if (_productCount < this._capacity)
        {
            this._productShelf[_productCount] = item;
            _productCount++;
            return true;
        }

        return false;
    }

    public void PrintProducts()
    {
        for (int i = 0; i < _productCount; i++)
        {
            this._productShelf[i].PrintDetails();
        }
    }
}
