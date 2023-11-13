using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CFI.DB
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }
        public string ConnectionString { get; set; }

        public DbSession(IConfiguration configuration)
        {
            this.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            //Connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            Connection = new SqlConnection(this.ConnectionString);
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();

    }
}
