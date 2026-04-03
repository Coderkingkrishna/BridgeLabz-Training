using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

public class SqlStorageProvider : IStorageProvider
{
    private string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public void Save(AddressBookData data)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            using SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                foreach (var book in data.Books)
                {
                    //  Insert AddressBook if not exists and get ID
                    SqlCommand bookCmd = new SqlCommand(
                        @"IF NOT EXISTS (SELECT 1 FROM AddressBooks WHERE BookName = @Name)
                          INSERT INTO AddressBooks (BookName) VALUES (@Name);

                          SELECT AddressBookId FROM AddressBooks WHERE BookName = @Name;",
                        conn,
                        transaction
                    );

                    bookCmd.Parameters.AddWithValue("@Name", book.Key);

                    int addressBookId = (int)bookCmd.ExecuteScalar();

                    //  DELETE old contacts (Prevents duplicate error)
                    SqlCommand deleteCmd = new SqlCommand(
                        "DELETE FROM Contacts WHERE AddressBookId = @BookId",
                        conn,
                        transaction
                    );

                    deleteCmd.Parameters.AddWithValue("@BookId", addressBookId);
                    deleteCmd.ExecuteNonQuery();

                    // Insert fresh contacts
                    foreach (var c in book.Value)
                    {
                        SqlCommand insertCmd = new SqlCommand(
                            @"INSERT INTO Contacts
                              (AddressBookId, FirstName, LastName, Address, City, State, Zip, Phone, Email)
                              VALUES
                              (@BookId, @First, @Last, @Address, @City, @State, @Zip, @Phone, @Email)",
                            conn,
                            transaction
                        );

                        insertCmd.Parameters.AddWithValue("@BookId", addressBookId);
                        insertCmd.Parameters.AddWithValue("@First", c.FirstName ?? "");
                        insertCmd.Parameters.AddWithValue("@Last", c.LastName ?? "");
                        insertCmd.Parameters.AddWithValue("@Address", c.Address ?? "");
                        insertCmd.Parameters.AddWithValue("@City", c.City ?? "");
                        insertCmd.Parameters.AddWithValue("@State", c.State ?? "");
                        insertCmd.Parameters.AddWithValue("@Zip", c.Zip ?? "");
                        insertCmd.Parameters.AddWithValue("@Phone", c.PhoneNumber ?? "");
                        insertCmd.Parameters.AddWithValue("@Email", c.Email ?? "");

                        insertCmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit(); // Save everything
            }
            catch
            {
                transaction.Rollback(); //  Undo if error
                throw;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
    }

    public AddressBookData Load()
    {
        AddressBookData data = new AddressBookData();

        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                @"SELECT b.BookName, c.FirstName, c.LastName, c.Address,
                         c.City, c.State, c.Zip, c.Phone, c.Email
                  FROM Contacts c
                  INNER JOIN AddressBooks b
                  ON c.AddressBookId = b.AddressBookId",
                conn
            );

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string bookName = reader["BookName"].ToString();

                if (!data.Books.ContainsKey(bookName))
                    data.Books[bookName] = new List<ContactPerson>();

                data.Books[bookName]
                    .Add(
                        new ContactPerson
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Zip = reader["Zip"].ToString(),
                            PhoneNumber = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                        }
                    );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("SQL Load Error: " + ex.Message);
        }

        return data;
    }
}
