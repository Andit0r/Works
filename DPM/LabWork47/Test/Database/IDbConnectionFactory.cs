using System.Data;

namespace DbLibrary.Database
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
