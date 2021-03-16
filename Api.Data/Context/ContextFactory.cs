using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    class ContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var conn = "Server=localhost,1433;Database=taskManager;Uid=sa;Pwd=Sqlsa!23";
            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer(conn);
            return new SqlContext(optionsBuilder.Options);
        }
    }
}
