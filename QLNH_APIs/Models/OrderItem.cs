using System;
using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models{

    public class OrderItem{

        [Key]public int id {get;set;}
        public string name {get;set;}
        public string Description {get;set;}
        public DateTime Created {get;set;}
        public DateTime Updated {get;set;}
        public bool Deleted {get;set;}
        public bool voided {get;set;}
        public double SalePrice {get;set;}
        public virtual Item Item {get; set;}

    }
}