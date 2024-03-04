using System;
using System.Data;
using System.Data.SqlClient;
namespace Data
{
    public class DataUser
    {
       public DataTable ShowUSer()
            {
                SqlDataReader result;
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection();

                try
                {
                    conn = connection.create().createConnection();
                    SqlCommand command = new SqlCommand("show_users", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    result = command.ExecuteReader();
                    dt.Load(result);
                    return dt;
                }catch (Exception ex)
                {
                    throw ex;
                    if (conn.State == ConnectionState.Open)conn.Close();
                }
            }


        public DataTable SearchUser(string data)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = connection.create().createConnection();
                SqlCommand command = new SqlCommand("search_users", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@data",SqlDbType.VarChar).Value = data;
                conn.Open();
                result = command.ExecuteReader();
                dt.Load(result);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public string InsertUser(User obj)
        {
            string answer = "";
            SqlConnection conn = new SqlConnection();
           

            try
            {
                conn = connection.create().createConnection();
                SqlCommand command = new SqlCommand("add_users", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                command.Parameters.Add("@dateBirth", SqlDbType.Date).Value = obj.DateBirth;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = obj.Gender;
                conn.Open();
                answer = command.ExecuteNonQuery() == 1 ? "Successful" : "Error, please validate, the registration could not be completed.";
            }
            catch (Exception ex)
            {
                answer = ex.Message;

                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return answer;
        }


        public string UpdatetUser(User obj)
        {
            string answer = "";
            SqlConnection conn = new SqlConnection();


            try
            {
                conn = connection.create().createConnection();
                SqlCommand command = new SqlCommand("update_users", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = obj.Name;
                command.Parameters.Add("@dateBirth", SqlDbType.Date).Value = obj.DateBirth;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = obj.Gender;
                conn.Open();
                answer = command.ExecuteNonQuery() == 1 ? "Successful" : "Error, please validate, the update could not be completed.";
            }
            catch (Exception ex)
            {
                answer = ex.Message;

                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return answer;
        }

        public string DeletetUser(int Id)
        {
            string answer = "";
            SqlConnection conn = new SqlConnection();


            try
            {
                conn = connection.create().createConnection();
                SqlCommand command = new SqlCommand("delete_users", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                conn.Open();
                answer = command.ExecuteNonQuery() == 1 ? "Successful" : "Error, please validate, the delete could not be completed.";
            }
            catch (Exception ex)
            {
                answer = ex.Message;

                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return answer;
        }
    }
}
