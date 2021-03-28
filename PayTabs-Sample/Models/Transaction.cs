using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace PayTabs_Sample.Models
{
    [Table("pt_transaction")]
    public class Transaction
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        [System.ComponentModel.DefaultValue(false)]
        public bool TriedToPay { get; set; }

        [JsonIgnore]
        public bool IsSucceed { get; set; }

        [JsonIgnore]
        public string Tran_Ref { get; set; }

        [JsonIgnore]
        public bool IsValid_Signature { get; set; }

        //

        [JsonProperty(PropertyName = "profile_id")]
        public int ProfileId { get; set; }

        [JsonIgnore]
        public string ServerKey { get; set; }

        //[JsonProperty(PropertyName = "payment_methods")]
        //public string[] PaymentMethods { get; set; }

        [JsonProperty(PropertyName = "tran_type")]
        public string TranType { get; set; }

        [JsonProperty(PropertyName = "tran_class")]
        public string TranClass { get; set; }

        [JsonProperty(PropertyName = "cart_id")]
        public string CartId { get; set; }

        [JsonProperty(PropertyName = "cart_currency")]
        public string CartCurrency { get; set; }

        [JsonProperty(PropertyName = "cart_amount")]
        public float CartAmount { get; set; }

        [JsonProperty(PropertyName = "cart_description")]
        public string CartDescription { get; set; }


        [JsonProperty(PropertyName = "paypage_lang")]
        public string PaypageLang { get; set; }

        //

        //public CustomerDetails CustomerDetails { get; set; }
        //public CustomerDetails ShippingDetails { get; set; }

        //

        [JsonProperty(PropertyName = "hide_shipping")]
        public bool HideShipping { get; set; }

        [JsonProperty(PropertyName = "framed")]
        public bool IsFramed { get; set; }

        //

        [JsonProperty(PropertyName = "return")]
        public string ReturnURL { get; set; }

        [JsonProperty(PropertyName = "callback")]
        public string CallbackURL { get; set; }

    }
}
