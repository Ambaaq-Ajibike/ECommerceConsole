using System;
namespace EcommerceProject.Entities
{
    public class User
    {
        public int ID{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Address{get; set;}
        public string Password{get; set;}
        public string Email{get; set;}
        public Roles Roles{get; set;}
        
    }
}