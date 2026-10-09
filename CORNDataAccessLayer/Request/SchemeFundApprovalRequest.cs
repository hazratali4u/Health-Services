namespace CORNDataAccessLayer.Request
{
    public class SchemeFundApprovalRequest
    {
        public SchemeFundApproval SchemeFundApprovalObject { get; set; }
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchemeId { get; set; }
    }
}
