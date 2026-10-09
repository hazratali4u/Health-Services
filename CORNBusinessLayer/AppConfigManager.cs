using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class AppConfigManager
    {
        public AppConfigResponse AppConfigGetId(AppConfigRequest request)
        {
            AppConfigDataAccess dataAccess = new AppConfigDataAccess();

            return dataAccess.AppConfigGetId(request);
        }
    }
}
