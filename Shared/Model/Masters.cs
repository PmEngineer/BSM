using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM.Shared.Model
{
    public class Masters : Utility
    {
        public string name { get; set; }
        public string company_name { get; set; }
        public string Address { get; set; }
        public int city_id { get; set; }
        public int states_id { get; set; }
        public int country_id { get; set; }
        public string zip_code { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string gst_number { get; set; }
        public int companyType_id { get; set; }  
        public string category_name { get; set; }  
        public int company_id { get; set; }  

    }
}
