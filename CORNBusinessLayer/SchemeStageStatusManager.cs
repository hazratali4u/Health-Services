using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeStageStatusManager
    {
        public SchemeStageStatusResponse SchemeStageStatusGetAll()
        {
            SchemeStageStatusDataAccess dataAccess = new SchemeStageStatusDataAccess();

            return dataAccess.SchemeStageStatusGetAll();
        }
    }
}
