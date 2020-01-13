using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Warsztat_3.Models;

namespace Warsztat_3
{
    public class SourceManager
    {
        const string connectionString = @"Data Source=TOMMY-LAPTOP\SQLEXPRESS;Initial Catalog = PhoneBook; Integrated Security = True";
        public static List<PersonModel> Get(int start, int take)
        {
            var phoneList = new List<PersonModel>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try

                {
                    using (var cmd = conn.CreateCommand())
                    {
                        // cmd.CommandText = @"SELECT Lastname FROM Users WHERE Firstname like '" + firstNameStartWith +"%'";
                        //cmd.CommandText = @"SELECT * FROM People ORDER BY ID OFFSET @start ROWS FETCH NEXT @take ROWS ONLY";
                        cmd.CommandText = @"SELECT * FROM People";
                        cmd.Parameters.AddWithValue("@start", start);
                        cmd.Parameters.AddWithValue("@take", take);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                phoneList.Add(new PersonModel
                                {
                                    ID = (int)reader["ID"],
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Phone = (int)reader["Phone"],
                                    Email = reader["Email"].ToString(),
                                    Created = (DateTime)reader["Created"]
                                    //,
                                    //Updated = (DateTime)reader["Update"] !=null?Convert.ToDateTime(reader["Updated"]):DateTime.Now
                                        
                            });
                            }
                        }
                    }
                }
                catch
                {
                   
                }
            }
            //return phoneList.Skip((start-1)*take).Take(take).ToList();
            return phoneList;

        }

        public static int Add (PersonModel person)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO People (FirstName, LastName, Phone, Email, Created) " +
                                      $"VALUES (@FirstName, @LastName, @Phone, @Email, @Created)";

                    // wersja skrocona
                    cmd.Parameters.Add(new SqlParameter("@FirstName", person.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", person.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Phone", person.Phone));
                    cmd.Parameters.Add(new SqlParameter("@Email", person.Email));
                    cmd.Parameters.Add(new SqlParameter("@Created", DateTime.Now));
                    var rowCount = cmd.ExecuteNonQuery();
                }
            }
            return 0;
        }
        public static PersonModel GetByID (int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM People WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    var person = cmd.ExecuteReader();
                    person.Read();
                    PersonModel personModel = new PersonModel {
                        ID = id,
                        FirstName = person["FirstName"].ToString(),
                        LastName = person["LastName"].ToString(),
                        Phone = (int)person["Phone"],
                        Email = person["Email"].ToString(),
                        Created = (DateTime)person["Created"]//,
                        //Updated = (DateTime)person["Updated"]
                    };
                    return personModel;
                }
            }                
        }

        public static void Update (PersonModel person)
        {
            
        }

        public static void Remove (int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[People] WHERE ID=@id";
                    cmd.Parameters.AddWithValue("@id", $"{id}");
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
