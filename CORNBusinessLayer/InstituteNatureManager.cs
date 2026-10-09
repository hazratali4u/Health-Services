using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class InstituteNatureManager
    {
        public InstituteNatureResponse InstituteNatureGetAll()
        {
            InstituteNatureDataAccess dataAccess = new InstituteNatureDataAccess();

            return dataAccess.InstituteNatureGetAll();
        }
        public InstituteNatureResponse InstituteNatureGetId(InstituteNatureRequest request)
        {
            InstituteNatureDataAccess dataAccess = new InstituteNatureDataAccess();

            return dataAccess.InstituteNatureGetId(request);
        }
        public InstituteNatureResponse InstituteNatureAdd(InstituteNatureRequest request)
        {
            InstituteNatureDataAccess dataAccess = new InstituteNatureDataAccess();

            return dataAccess.InstituteNatureAdd(request);
        }
        public InstituteNatureResponse InstituteNatureUpdate(InstituteNatureRequest request)
        {
            InstituteNatureDataAccess dataAccess = new InstituteNatureDataAccess();

            return dataAccess.InstituteNatureUpdate(request);
        }
        public InstituteNatureResponse InstituteNatureDelete(InstituteNatureRequest request)
        {
            InstituteNatureDataAccess dataAccess = new InstituteNatureDataAccess();

            return dataAccess.InstituteNatureDelete(request);
        }
    }
}
