using System;
namespace EcommerceProject.Entities
{
    public class Order
    {
        public int ID{get; set;}
        public int ProductID{get; set;}
        public Product Product{get; set;}
        public int Quantity{get; set;}
        public OrderStatus OrderStatus{get; set;}
        public DateTime OrderDate{get; set;}
        public int VendorId{get; set;}
        public Vendor Vendor{get; set;}
        public int CustomerId{get; set;}
        public Customer Customer{get; set;}

    }
}