using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class ExecutionResponse
    {
        public List<Execution> ExecutionList { get; set; }
        public Execution ExecutionObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
