//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminListEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public object Items { get; internal set; }

        public Item()
        {
            ID = 0;
            Name = "";
            Description = "";
            Quantity = 0;
            Price = 0;
        }
        public Item(int iD, string name, string description, int quantity, int price)
        {
            ID = iD;
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}
