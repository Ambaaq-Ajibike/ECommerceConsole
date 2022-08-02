using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceProject.Entities
{
    public class Vendor
    {
        [Key]
        [ForeignKey("User")]
        public int UserID{get; set;}
        public User User{get; set;}        
        public string Address{get; set;}
        public List<Product> Products{get; set;}
        public List<Order> Orders{get; set;}
    }
}