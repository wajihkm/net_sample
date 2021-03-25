using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayTabs_Sample.Models
{
    [Table("pt_transaction")]
    public class Transaction
    {
        public int Id { get; set; }

        //

        public int ProfileId { get; set; }
        public string ServerKey { get; set; }

        public string TranType { get; set; }

        public string CartId { get; set; }
        public string CartCurrency { get; set; }
        public float CartAmount { get; set; }
        public string CartDescription { get; set; }

        public string PaypageLang { get; set; }

        //

        //public CustomerDetails CustomerDetails { get; set; }
        //public CustomerDetails ShippingDetails { get; set; }

        //

        public string ReturnURL { get; set; }
        public string CallbackURL { get; set; }

    }
}
