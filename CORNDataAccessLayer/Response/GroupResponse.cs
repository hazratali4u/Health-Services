using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class GroupResponse
    {
        public List<Group> GroupList { get; set; }
        public Group GroupObject { get; set; }
        public List<GroupAccountHead> GroupAccountHeadList { get; set; }
        public bool Status { get; set; }
    }
}
