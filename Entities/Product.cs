using System;
using System.Collections;
using System.Collections.Generic;
namespace EcommerceProject.Entities
{
    public class Product
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public string Description{get; set;}
        public double SellingPrice{get; set;}
        public double CostPrice{get; set;}
        public int Quantity{get; set;}
        DateTime DateCreated{get; set;}
        public int CategoryId{get; set;}
        public Category Category{get; set;}
        public IList<Order> Orders{get; set;} = new List<Order>();
        public int VendorId{get; set;}
        public Vendor Vendor{get; set;}
    }
}