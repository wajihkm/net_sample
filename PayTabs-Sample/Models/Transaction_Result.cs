using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Net;

namespace PayTabs_Sample.Models
{
    public class Transaction_Result
    {
        public string tranRef { get; set; }

        public string respCode { get; set; }
        public string respMessage { get; set; }
        public string respStatus { get; set; }

        public string acquirerMessage { get; set; }
        public string acquirerRRN { get; set; }

        public string cartId { get; set; }
        public string customerEmail { get; set; }

        public string signature { get; set; }

        public string token { get; set; }
        

        //

        public bool IsValid_Signature()
        {
            string server_key = "SRJNLKK2Z2-HWRGM6JDZM-MGMGGNW9JZ";

            var dic = this.ToDictionary();

            // 1
            string signature = dic["signature"];
            dic.Remove("signature");

            // 2
            dic = dic
                .Where(k => k.Value != null && k.Value.Trim().Length > 0)
                .ToDictionary(x => x.Key, x => x.Value);

            // 3
            dic = dic
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            // 4

            string query = string.Join("&", dic.Select(x => x.Key + "=" + WebUtility.UrlEncode(x.Value)).ToArray());

            // 5


            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(server_key)))
            {
                byte[] hashed = hmac.ComputeHash(Encoding.UTF8.GetBytes(query));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashed.Length; i++)
                {
                    builder.Append(hashed[i].ToString("x2"));
                }
                string hashed_str = builder.ToString();

                return hashed_str.Equals(signature);
            }

            //return false;
        }

        //

        private Dictionary<string, string> ToDictionary()
        {
            var json = JsonConvert.SerializeObject(this);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            return dictionary;
        }
    }
}
