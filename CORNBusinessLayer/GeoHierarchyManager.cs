using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class GeoHierarchyManager
    {
        public GeoHierarchyResponse GeoHierarchyGetAll()
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyGetAll();
        }
        public GeoHierarchyResponse GeoHierarchyGetId(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyGetId(request);
        }
        public GeoHierarchyResponse GeoHierarchyAdd(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyAdd(request);
        }
        public GeoHierarchyResponse GeoHierarchyUpdate(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyUpdate(request);
        }
        public GeoHierarchyResponse GeoHierarchyDelete(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyDelete(request);
        }
        public GeoHierarchyResponse GeoHierarchyGetTypeId(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyGetTypeId(request);
        }
        public GeoHierarchyResponse GeoHierarchyGetTypeIdParentId(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyGetTypeIdParentId(request);
        }
        public GeoHierarchyResponse GeoHierarchyConstituencyGetDistrictId(GeoHierarchyRequest request)
        {
            GeoHierarchyDataAccess dataAccess = new GeoHierarchyDataAccess();

            return dataAccess.GeoHierarchyConstituencyGetDistrictId(request);
        }
    }
}
