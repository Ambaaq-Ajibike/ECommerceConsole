using System;
namespace EcommerceProject.Entities
{
    public class Wallet
    {
        public int ID{get; set;}
        public int UserID{get; set;}
        public User User{get; set;}
        public double Balance{get; set;}
        public string Pin{get; set;}
    }
}