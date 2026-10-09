using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class OperationMaintenanceManager
    {
        public OperationMaintenanceResponse OperationMaintenanceGetAll()
        {
            OperationMaintenanceDataAccess dataAccess = new OperationMaintenanceDataAccess();

            return dataAccess.OperationMaintenanceGetAll();
        }
        public OperationMaintenanceResponse OperationMaintenanceGetId(OperationMaintenanceRequest request)
        {
            OperationMaintenanceDataAccess dataAccess = new OperationMaintenanceDataAccess();

            return dataAccess.OperationMaintenanceGetId(request);
        }
        public OperationMaintenanceResponse OperationMaintenanceAdd(OperationMaintenanceRequest request)
        {
            OperationMaintenanceDataAccess dataAccess = new OperationMaintenanceDataAccess();

            return dataAccess.OperationMaintenanceAdd(request);
        }
        public OperationMaintenanceResponse OperationMaintenanceUpdate(OperationMaintenanceRequest request)
        {
            OperationMaintenanceDataAccess dataAccess = new OperationMaintenanceDataAccess();

            return dataAccess.OperationMaintenanceUpdate(request);
        }
        public OperationMaintenanceResponse OperationMaintenanceDelete(OperationMaintenanceRequest request)
        {
            OperationMaintenanceDataAccess dataAccess = new OperationMaintenanceDataAccess();

            return dataAccess.OperationMaintenanceDelete(request);
        }
    }
}
