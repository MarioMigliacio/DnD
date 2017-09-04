using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;

namespace MonsterGenerator
{
    public partial class MonsterGenerator : Form
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mario\documents\visual studio 2015\Projects\DnD\MonsterGenerator\MonsterDb.mdf;Integrated Security=True";

        public MonsterGenerator()
        {
            InitializeComponent();

            try
            {
                List<string> nameField = new List<string>();
                List<float> crField = new List<float>();
                List<string> typeField = new List<string>();

                using (TextFieldParser parser = new TextFieldParser(@"db_file.txt"))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] line = parser.ReadFields();

                        // the name field of the data.
                        nameField.Add(line[0].Replace(" ", string.Empty));

                        // the cr field of the data.
                        float num = 0f;
                        bool convertedNumber = float.TryParse(line[1], out num);

                        if (convertedNumber)
                        {
                            crField.Add(num);
                        }
                        else
                        {
                            throw new Exception("Error converting the cr to a float.");
                        }

                        // the type field of the data.
                        typeField.Add(line[2]);
                    }

                    // kill whatever is in the current Database.
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        string queryString = $"TRUNCATE TABLE dbo.MonsterDb";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }

                    // if the data in the file is in a valid state, add all the rows into the database.
                    if (typeField.Count == crField.Count && typeField.Count == nameField.Count)
                    {
                        for (int i = 0; i < typeField.Count; i++)
                        {
                            using (SqlConnection connection = new SqlConnection(_connectionString))
                            {
                                connection.Open();
                                string queryString = $"INSERT INTO MonsterDB VALUES('{nameField[i]}', {crField[i]}, '{typeField[i]}');";
                                SqlCommand command = new SqlCommand(queryString, connection);
                                SqlDataReader reader = command.ExecuteReader();
                                reader.Close();
                            }
                        }

                        // populate the textbox1 with the records in the database.
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        {
                            connection.Open();
                            string queryString = $"SELECT * FROM MonsterDB";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                StringBuilder boxContents = new StringBuilder();

                                while (reader.Read())
                                {
                                    comboBox1.Items.Add($"{reader.GetSqlString(1).ToString()}, {reader.GetDouble(2).ToString()}, { reader.GetSqlString(3).ToString()}");
                                }
                            }

                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // quick way to delete table: "TRUNCATE TABLE dbo.MonsterDb"
        // view table: "SELECT * FROM dbo.MonsterDb"
    }
}