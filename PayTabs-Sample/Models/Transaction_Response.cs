using System;

namespace PayTabs_Sample.Models
{
    public class Transaction_Response
    {
        public string tran_ref { get; set; }
        public string redirect_url { get; set; }


        public bool IsSuccess()
        {
            if (tran_ref == null || redirect_url == null)
                return false;

            if (redirect_url.Trim().Length == 0)
                return false;

            return true;
        }
    }
}
