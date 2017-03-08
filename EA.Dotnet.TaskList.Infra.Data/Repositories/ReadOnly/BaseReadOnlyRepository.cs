﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EA.Dotnet.TaskList.Infra.Data.Repositories.ReadOnly
{
    public class BaseReadOnlyRepository
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["TaskList"].ConnectionString);
            }
        }
    }
}
