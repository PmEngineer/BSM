using System.Data;

namespace BSM.Server
{
    public class CommonResponse
    {
        public int? responseCode { get; set; }
        public string responseMessage { get; set; }

        public DataSet responseValue { get; set; }
    }
}
