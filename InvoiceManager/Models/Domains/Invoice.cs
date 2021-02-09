using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceManager.Models.Domains
{
    public class Invoice
    {
        public Invoice()
        {
            InvoicePositions = new Collection<InvoicePosition>();
        }
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public Decimal Value { get; set; }

        public int MethodOfPaymantId { get; set; }
        public DateTime PaymantDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }
        public int ClientId { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public MethodOfPaymant MethoOfPaymant { get; set; }
        public Client Client { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<InvoicePosition> InvoicePositions { get; set; }
    }
}