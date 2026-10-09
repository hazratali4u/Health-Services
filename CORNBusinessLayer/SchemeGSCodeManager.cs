using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeGSCodeManager
    {
        public SchemeGSCodeResponse SchemeGSCodeGetSchemeId(SchemeGSCodeRequest request)
        {
            SchemeGSCodeDataAccess dataAccess = new SchemeGSCodeDataAccess();

            return dataAccess.SchemeGSCodeGetSchemeId(request);
        }
    }
}
