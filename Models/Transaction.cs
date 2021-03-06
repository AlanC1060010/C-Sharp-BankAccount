using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankaccount.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Display(Name = "Amount:")]
        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Each transaction has a UserID and belongs to a User object.

        public int UserId {get; set;}
        public User User{get; set;}
    }
}