using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM.Shared
{
    class Utility
    {
        public int userId { get; set; }
        public int id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class CommonResponse
    {
        public int status { get; set; }
        public string message { get; set; }
        public object responseValue { get; set; }
    }
}
