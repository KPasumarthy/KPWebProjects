using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;


namespace KPMVCWebAPIs.Database
{
    public class AdventureWorksDBContext : System.Data.Entity.DbContext 
    {
        public AdventureWorksDBContext() : base("AdventureWorksConnectionString")
        {
        }

    }
}

