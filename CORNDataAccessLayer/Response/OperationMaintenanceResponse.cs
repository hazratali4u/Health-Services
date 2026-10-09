using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class OperationMaintenanceResponse
    {
        public List<OperationMaintenance> OperationMaintenanceList { get; set; }
        public OperationMaintenance OperationMaintenanceObject { get; set; }
        public long Id { get; set; }
        public bool Status { get; set; }
    }
}
