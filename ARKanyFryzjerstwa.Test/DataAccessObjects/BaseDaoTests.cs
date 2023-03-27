using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    public abstract class BaseDaoTests<TDao> where TDao : BaseDao
    {
        private IdentityContext? _identityContext;
        protected TDao _dao;
        protected const int CURRENT_SALON_ID = 1;

        public IdentityContext Context
        {
            get
            {
                _identityContext ??= CreateIdentityContext();
                return _identityContext;
            }
        }

        public IDbContextTransaction? Transaction;

        protected abstract void SetDao();

        [SetUp]
        public void BaseSetup()
        {
            SetDao();
            Transaction = Context.Database.BeginTransaction();
        }

        [TearDown]
        public void BaseTearDown() 
        {
            Transaction?.Rollback();
            Transaction?.Dispose();
        }

        private static IdentityContext CreateIdentityContext()
        {
            var connectionString = "Data Source=sql.bsite.net\\MSSQL2016;" +
                "Initial Catalog=menor91_SampleDB;User ID=menor91_SampleDB;Password=menor91774@;" + 
                //"Initial Catalog=menor91_Test;User ID=menor91_Test;Password=menor91774@;" +
                "Persist Security Info=True;";
            var connection = new SqlConnection(connectionString);
            var options = new DbContextOptionsBuilder<IdentityContext>()
                .UseSqlServer(connection).Options;
            return new IdentityContext(options);
        }
    }
}
