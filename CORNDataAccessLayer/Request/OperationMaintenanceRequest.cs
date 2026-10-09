namespace CORNDataAccessLayer.Request
{
    public class OperationMaintenanceRequest
    {
        public OperationMaintenance OperationMaintenanceObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
    }
}
