using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeReappropriationManager
    {
        public SchemeReappropriationResponse SchemeReappropriationGetAll(SchemeReappropriationRequest request)
        {
            SchemeReappropriationDataAccess dataAccess = new SchemeReappropriationDataAccess();

            return dataAccess.SchemeReappropriationGetAll(request);
        }
        public SchemeReappropriationResponse SchemeReappropriationGetId(SchemeReappropriationRequest request)
        {
            SchemeReappropriationDataAccess dataAccess = new SchemeReappropriationDataAccess();

            return dataAccess.SchemeReappropriationGetId(request);
        }
        public SchemeReappropriationResponse SchemeReappropriationAdd(SchemeReappropriationRequest request)
        {
            SchemeReappropriationDataAccess dataAccess = new SchemeReappropriationDataAccess();

            return dataAccess.SchemeReappropriationAdd(request);
        }
        public SchemeReappropriationResponse SchemeReappropriationUpdate(SchemeReappropriationRequest request)
        {
            SchemeReappropriationDataAccess dataAccess = new SchemeReappropriationDataAccess();

            return dataAccess.SchemeReappropriationUpdate(request);
        }
    }
}
