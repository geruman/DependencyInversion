namespace Dependency_inversion
{
    public class Order
    {
        public string OrderName { get;private set; }
        public Order(string orderName)
        {
            OrderName = orderName;
        }
    }
}