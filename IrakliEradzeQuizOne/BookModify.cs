using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrakliEradzeQuizOne
{
    public class BookModify
    {
        public static string connectionString = @"Data Source=DESKTOP-OKIRIV8;Initial Catalog = EradzeQuiz;User ID = ;Password=;Integrated Security=True;";

        public string CreateBook(string title, string authorName)
        {
            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = @"INSERT INTO Book (Title,AuthorName) VALUES (@title,@authorName);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@authorName", authorName);

            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();

            return "Create operation succesfully ended...";
        }

        public static void ReadBooks(DataGridView dataGridView)
        {
            var dataAdapter = new SqlDataAdapter();
            var dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = $@"SELECT * FROM Book";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int i = command.ExecuteNonQuery();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public string UpdateBook(int id, string title, string authorName)
        {
            if (id > 0 && title != null || authorName != null)
            {
                var connection = new SqlConnection(connectionString: connectionString);

                var command = new SqlCommand("Update Book SET Title = @title, AuthorName = @authorName WHERE Id = @bookId ", connection);

                command.Parameters.AddWithValue("@bookId", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@authorName", authorName);

                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();

                return "Update operation succesfully ended...";
            }
            else
            {
                return "Something went wrong...";
            }
        }

        public void DeleteBook(int id)
        {
            var connection = new SqlConnection(connectionString: connectionString);

            connection.Open();

            var command = new SqlCommand("DELETE FROM Book WHERE Id = @bookId", connection);

            command.Parameters.AddWithValue("@bookId", id);
            command.ExecuteNonQuery();
        }

        public void Transactions()
        {
            string create = "INSERT INTO Book(Title,AuthorName) values ('Book1','Author1') ";
            string update = "UPDATE Book SET Title='Bookss2' WHERE AuthorName='Author2'";

            SqlConnection db = new SqlConnection(connectionString: connectionString);
            SqlTransaction transaction1;

            db.Open();
            transaction1 = db.BeginTransaction();

            try
            {
                SqlCommand insertCommand = new SqlCommand(create, db, transaction1);
                insertCommand.ExecuteNonQuery();

                SqlCommand updateCommand = new SqlCommand(update, db, transaction1);
                updateCommand.ExecuteNonQuery();

                transaction1.Commit();

                db.Close();
            }
            catch
            {
                transaction1.Rollback();
                db.Close();
            }
        }

        public void ExecuteProcedure(string title, string authorName)
        {
            string procedureName = "CreateBookProcedure";

            SqlConnection connection = new SqlConnection(connectionString: connectionString);

            SqlCommand command = new SqlCommand(procedureName, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@AuthorName", string.IsNullOrWhiteSpace(authorName) && authorName.Length < 50 ? authorName : null);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
