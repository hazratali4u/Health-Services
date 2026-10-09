using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class ExecutionManager
    {
        public ExecutionResponse ExecutionGetAll()
        {
            ExecutionDataAccess dataAccess = new ExecutionDataAccess();

            return dataAccess.ExecutionGetAll();
        }
        public ExecutionResponse ExecutionGetId(ExecutionRequest request)
        {
            ExecutionDataAccess dataAccess = new ExecutionDataAccess();

            return dataAccess.ExecutionGetId(request);
        }
        public ExecutionResponse ExecutionAdd(ExecutionRequest request)
        {
            ExecutionDataAccess dataAccess = new ExecutionDataAccess();

            return dataAccess.ExecutionAdd(request);
        }
        public ExecutionResponse ExecutionUpdate(ExecutionRequest request)
        {
            ExecutionDataAccess dataAccess = new ExecutionDataAccess();

            return dataAccess.ExecutionUpdate(request);
        }
        public ExecutionResponse ExecutionDelete(ExecutionRequest request)
        {
            ExecutionDataAccess dataAccess = new ExecutionDataAccess();

            return dataAccess.ExecutionDelete(request);
        }
    }
}
