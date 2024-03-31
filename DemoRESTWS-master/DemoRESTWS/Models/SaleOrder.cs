namespace DemoRESTWS.Models
{
    public class SaleOrder
    {
        public int IdSaleOrder { get; }
        public Customer ObjCustomer { get; }
        public List<Product> LstProducts { get; }
        public DateTime OrderDate { get; }

        public SaleOrder(int _IdSaleOrder, Customer _ObjCustomer, List<Product> _LstProducts, DateTime _OrderDate)
        {
            IdSaleOrder= _IdSaleOrder;
            ObjCustomer= _ObjCustomer;
            LstProducts= _LstProducts;
            OrderDate= _OrderDate;
        }
    }
}
