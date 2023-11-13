using CFI.Controllers.Interfaces;
using CFI.DB;
using CFI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace CFI.Controllers
{
    public class FinancialInstrumentController : IFinancialInstrumentController
    {
        private readonly DbSession db;

        public FinancialInstrumentController(DbSession dbSession)
        {
            if (dbSession.Connection.ConnectionString.Trim() == "")
                dbSession.Connection.ConnectionString = dbSession.ConnectionString;
            db = dbSession;
        }
        public InstrumentOutput GenerateAndBringOutput(string nickName, double marketValue, string type)
        {
            string storedProcedure = "";

            if (db.Connection.ConnectionString.Trim() == "")
                db.Connection.ConnectionString = db.ConnectionString;

            storedProcedure += "GenerateOutput";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("NickName", nickName);
            parameters.Add("MarketValue", marketValue);
            parameters.Add("Type", type);

            using (var conn = db.Connection)
            {
                InstrumentOutput instrumentOutput = conn.QuerySingleOrDefault<InstrumentOutput>(storedProcedure, parameters, commandType: System.Data.CommandType.StoredProcedure);
                return instrumentOutput;
            }
        }
    }
}
