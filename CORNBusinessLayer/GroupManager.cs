using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class GroupManager
    {
        public GroupResponse GroupGetAll()
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupGetAll();
        }
        public GroupResponse GroupGetId(GroupRequest request)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupGetId(request);
        }
        public GroupResponse GroupAdd(GroupRequest request)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupAdd(request);
        }
        public GroupResponse GroupUpdate(GroupRequest request)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupUpdate(request);
        }
        public GroupResponse GroupDelete(GroupRequest request)
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupDelete(request);
        }
        public GroupResponse GroupGetAllDetail()
        {
            GroupDataAccess dataAccess = new GroupDataAccess();

            return dataAccess.GroupGetAllDetail();
        }
    }
}
