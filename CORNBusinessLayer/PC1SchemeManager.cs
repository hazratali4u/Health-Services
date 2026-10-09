using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class PC1SchemeManager
    {
        public SchemeResponse SchemeGetAll(SchemeRequest request)
        {
            PC1SchemeDataAccess dataAccess = new PC1SchemeDataAccess();

            return dataAccess.SchemeGetAll(request);
        }
        public SchemeResponse SchemeGetId(SchemeRequest request)
        {
            PC1SchemeDataAccess dataAccess = new PC1SchemeDataAccess();

            return dataAccess.SchemeGetId(request);
        }
        public SchemeResponse SchemeAdd(SchemeRequest request)
        {
            PC1SchemeDataAccess dataAccess = new PC1SchemeDataAccess();

            return dataAccess.SchemeAdd(request);
        }
        public SchemeResponse SchemeUpdate(SchemeRequest request)
        {
            PC1SchemeDataAccess dataAccess = new PC1SchemeDataAccess();

            return dataAccess.SchemeUpdate(request);
        }
        public SchemeResponse SchemeGetAllFundApproval(SchemeRequest request)
        {
            PC1SchemeDataAccess dataAccess = new PC1SchemeDataAccess();

            return dataAccess.SchemeGetAllFundApproval(request);
        }
    }
}
