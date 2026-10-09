using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class PC1SchemeStageManager
    {
        public SchemeStageResponse SchemeStageGetAll(SchemeStageRequest request)
        {
            PC1SchemeStageDataAccess dataAccess = new PC1SchemeStageDataAccess();

            return dataAccess.SchemeStageGetAll(request);
        }
        public SchemeStageResponse SchemeStageAdd(SchemeStageRequest request)
        {
            PC1SchemeStageDataAccess dataAccess = new PC1SchemeStageDataAccess();

            return dataAccess.SchemeStageAdd(request);
        }
    }
}
