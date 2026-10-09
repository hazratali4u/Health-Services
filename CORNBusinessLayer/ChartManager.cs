using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class ChartManager
    {
        public ChartResponse GenerateFundWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateFundWiseChart(request);
        }
        public ChartResponse GenerateStatusWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateStatusWiseChart(request);
        }
        public ChartResponse GenerateSubSectorWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateSubSectorWiseChart(request);
        }
        public ChartResponse GenerateObjectWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateObjectWiseChart(request);
        }
        public ChartResponse GenerateFunctionWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateFunctionWiseChart(request);
        }
        public ChartResponse GenerateConstituencyWiseChart(ChartRequest request)
        {
            ChartDataAccess dataAccess = new ChartDataAccess();

            return dataAccess.GenerateConstituencyWiseChart(request);
        }
    }
}
