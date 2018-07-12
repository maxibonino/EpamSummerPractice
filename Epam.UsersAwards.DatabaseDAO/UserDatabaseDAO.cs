using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using IUserDAO;

namespace Epam.UsersAwards.DatabaseDAO
{
    public class UserDatabaseDAO : IUserDAO, IEditPicture
    {

        // Заглушка
        //private readonly string _connectionString;
        //private object sqlDbType;

        //public UserDatabaseDAO()
        //{
        //    _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        //}

        //public int Add(string text)
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        SqlCommand command = connection.CreateCommand();
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //          command.CommandText = "Add<name Stored Procedure>";

        //        SqlParameter parameter = new SqlParameter("@field", System.Data.SqlDbType.NVarChar);

        //        parameter.Value = text;

        //        command.Parameters.Add(parameter);
        //          connection.Open();
        //        return (int)(decimal)command.ExecuteScalar(); //!!!!!!!!
        //    }
        //}

        //public IEnumerable<string> GetAll()
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        var command = connection.CreateCommand();
        //        command.CommandType = System.Data.CommandType.Text;

        //        command.CommandText = @"SELECT ... FROM ...";

        //        connection.Open();

        //        var reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            yield return new object
        //            {
        //                id = (int)reader["id"],
        //                text = (string)reader["string"],
        //            }
        //        }
        //    }
        //}
    }
}
