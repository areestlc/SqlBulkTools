using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace SqlBulkTools
{
    internal interface ITransaction
    {
        int Commit(IDbConnection connection, IDbTransaction transaction = null);

        int Commit(SqlConnection connection, SqlTransaction transaction);

        Task<int> CommitAsync(SqlConnection connection, SqlTransaction transaction);
    }
}