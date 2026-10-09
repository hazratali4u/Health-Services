using System.Collections.Generic;

namespace CORNDataAccessLayer
{
    public class CornReport
    {
        public List<Scheme> SchemeList { get; set; }
        public List<Institute> InstituteList { get; set; }
        public List<SchemeStage> SchemeStageList { get; set; }
        public List<SchemeFundApproval> SchemeFundApprovalList { get; set; }
        public List<SubSector> SubSectorList { get; set; }
        public List<AccountHead> AccountHeadList { get; set; }
        public List<CornObject> CornObjectList { get; set; }
    }
}
