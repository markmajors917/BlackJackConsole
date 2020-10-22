using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace GeneralStoreAPI.Models.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        //FK for Customer
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        //FK for Product
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public  virtual Product Product { get; set; }
        public DateTime DateOfTransaction { get; set; } = DateTime.Now;
    }
}