namespace StoreApp
{
    public class Item
    {
        
        public double itemCost;
        public int itemNumber;
        public int quantity;

        public Item(double cost, int type, int quant) {
            this.itemCost = cost;
            this.itemNumber = type;
            this.quantity = quant;
        }

        public double getCost()
        {
            return this.itemCost;
        }

        public int getItemNumber()
        {
            return this.itemNumber;
        }

        public int getQuantity() 
        {
            return this.quantity;
        }

    }
}