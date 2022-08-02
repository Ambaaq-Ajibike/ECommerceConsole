using System;
using System.Collections.Generic;
using System.Collections;
namespace EcommerceProject.Entities
{
    public class Category
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public IList<Product> Products{get; set;} = new List<Product>();
    }
}