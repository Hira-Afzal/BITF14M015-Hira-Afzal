//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace foodweb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        public Food()
        {
            this.Carts = new HashSet<Cart>();
            this.Carts1 = new HashSet<Cart>();
            this.Carts2 = new HashSet<Cart>();
            this.Carts3 = new HashSet<Cart>();
            this.Carts4 = new HashSet<Cart>();
            this.Carts5 = new HashSet<Cart>();
        }
    
        public int Id { get; set; }
        public string DishName { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Cart> Carts1 { get; set; }
        public virtual ICollection<Cart> Carts2 { get; set; }
        public virtual ICollection<Cart> Carts3 { get; set; }
        public virtual ICollection<Cart> Carts4 { get; set; }
        public virtual ICollection<Cart> Carts5 { get; set; }
    }
}
