using CORNCommon;
using CORNCommon.Classes;
using CORNDataAccessLayer;
using CORNDataAccessLayer.Classes;
using CORNDataAccessLayer.Response;
using System.Data;
using System.Linq;

namespace CORNDatabaseLayer
{
    public class SchemePOReferenceNoDataAccess
    {
        public SchemePOReferenceNoResponse SchemePOReferenceNoGetAll()
        {
            SchemePOReferenceNoResponse response = new SchemePOReferenceNoResponse();
            IDbConnection mConnection = null;

            mConnection = ProviderFactory.GetConnection(Configuration.ConnectionString, EnumProviders.SQLClient);
            mConnection.Open();

            IDbCommand command = ProviderFactory.GetCommand(EnumProviders.SQLClient);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = DBConstants.SchemePOReferenceNoDBConstant.TBL_SCHEMEPOREFERENCENO_GET_ALL;
            command.Connection = mConnection;

            IDbDataAdapter da = ProviderFactory.GetAdapter(EnumProviders.SQLClient);
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                response.SchemePOReferenceNoList = ds.Tables[0].ToList<SchemePOReferenceNo>();
            }

            return response;
        }
    }
}
