using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models{

    public class Order{

        [Key]public int id {get;set;}
        public int OrderNumber {get;set;}
        public string Description {get;set;}
        public DateTime Created {get;set;}
        public DateTime Updated {get;set;}
        public bool Deleted {get;set;}
        public bool voided {get;set;}
        public double TotalPrice {get;set;}
        public double PaiAmount {get;set;}
        public virtual IList<OrderItem> OrderItem {get;set;}

    }
}