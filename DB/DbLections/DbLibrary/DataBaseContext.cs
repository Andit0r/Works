using Dapper;
using DbLibrary.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DbLibrary
{
    public class DataBaseContext
    {

        public static string ConnectionString { get; set; } =
            "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";

        public static void ExecuteCommand(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            SqlCommand command = new(query, connection);
            command.ExecuteNonQuery();
        }

        public static void FindStudent(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();


            SqlCommand command = new(query, connection);

            //command.Parameters.AddWithValue("@е", )
            command.ExecuteNonQuery();
        }

        public static void ChangePrice(string title, int price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "UPDATE Game SET Price=@price WHERE Title=@title";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@title", title);

            command.ExecuteNonQuery();
        }

        public static string FindGameTitle(int id)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT Title FROM Game WHERE Id=@id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.Add("@title", SqlDbType.NVarChar, 300);
            command.Parameters["@title"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            return command.Parameters["@title"].Value.ToString();
        }

        public static IEnumerable<Review> GetReviews()
        {
            IDbConnection db = new SqlConnection(ConnectionString);

            return db.Query<Review>("SELECT * FROM Review");
        }

        public static Review? GetReview(int id)
        {
            IDbConnection db = new SqlConnection(ConnectionString);
            return db.QueryFirstOrDefault<Review>("SELECT * FROM Review WHERE Id=@id;", new { id });
        }

        public static void UpdateReview(Review review)
        {
            IDbConnection db = new SqlConnection(ConnectionString);
            db.Execute("UPDATE Review SET Comment=@Comment WHERE Id=@Id;", review);
        }
    }


}
