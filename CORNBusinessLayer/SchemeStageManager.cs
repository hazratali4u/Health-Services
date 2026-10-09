using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeStageManager
    {
        public SchemeStageResponse SchemeStageGetAll(SchemeStageRequest request)
        {
            SchemeStageDataAccess dataAccess = new SchemeStageDataAccess();

            return dataAccess.SchemeStageGetAll(request);
        }
        public SchemeStageResponse SchemeStageAdd(SchemeStageRequest request)
        {
            SchemeStageDataAccess dataAccess = new SchemeStageDataAccess();

            return dataAccess.SchemeStageAdd(request);
        }
    }
}
