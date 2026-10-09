using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeDocumentManager
    {
        public SchemeDocumentResponse SchemeDocumentGetAll(SchemeDocumentRequest request)
        {
            SchemeDocumentDataAccess dataAccess = new SchemeDocumentDataAccess();

            return dataAccess.SchemeDocumentGetAll(request);
        }
        public SchemeDocumentResponse DocumentGetId(SchemeDocumentRequest request)
        {
            SchemeDocumentDataAccess dataAccess = new SchemeDocumentDataAccess();

            return dataAccess.DocumentGetId(request);
        }
        public SchemeDocumentResponse SchemeDocumentAdd(SchemeDocumentRequest request)
        {
            SchemeDocumentDataAccess dataAccess = new SchemeDocumentDataAccess();

            return dataAccess.SchemeDocumentAdd(request);
        }
        public SchemeDocumentResponse SchemeDocumentUpdate(SchemeDocumentRequest request)
        {
            SchemeDocumentDataAccess dataAccess = new SchemeDocumentDataAccess();

            return dataAccess.SchemeDocumentUpdate(request);
        }
        public SchemeDocumentResponse SchemeDocumentDelete(SchemeDocumentRequest request)
        {
            SchemeDocumentDataAccess dataAccess = new SchemeDocumentDataAccess();

            return dataAccess.SchemeDocumentDelete(request);
        }
    }
}
