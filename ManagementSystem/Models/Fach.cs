using ManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{
    public class Fach
    {
        // Eigenschaften
        DBConnect connection = new DBConnect();


        // Fach neu anlegen
        public bool InsertFach(string bezeichnung, string stufe, string beschreibung, int? lehrerPersID = null)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Faecher(Bezeichnung, Stufe, Beschreibung, LehrerPersID) " +
                                                    "VALUES (@Bezeichnung, @Stufe, @Beschreibung, @LehrerPersID)",
                                                        connection.GetConnection);

            command.Parameters.Add("@Bezeichnung", SqlDbType.VarChar).Value = bezeichnung;
            command.Parameters.Add("@Stufe", SqlDbType.VarChar).Value = stufe;
            command.Parameters.Add("@Beschreibung", SqlDbType.Text).Value = beschreibung;
            command.Parameters.Add("@LehrerPersID", SqlDbType.Int).Value = lehrerPersID;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        // Fach bearbeiten
        public bool UpdateFach(int id, string bezeichnung, string stufe, string beschreibung, int? lehrerPersID)
        {
            SqlCommand command = new SqlCommand("UPDATE Faecher " +
                                                "SET Bezeichnung = @Bezeichnung, Stufe = @Stufe, Beschreibung = @Beschreibung, LehrerPersID = @LehrerPersID " +
                                                "WHERE FachID = @FachID",
                                                        connection.GetConnection);

            command.Parameters.Add("@FachID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Bezeichnung", SqlDbType.VarChar).Value = bezeichnung;
            command.Parameters.Add("@Stufe", SqlDbType.VarChar).Value = stufe;
            command.Parameters.Add("@Beschreibung", SqlDbType.Text).Value = beschreibung;
            command.Parameters.Add("@LehrerPersID", SqlDbType.Int).Value = lehrerPersID;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        // Fach entfernen
        public DataTable DeleteFach(string id)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Faecher WHERE FachID = '{id}'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Alle Faecher in Tabellenform aus der Datenbank holen
        public DataTable GetAllFaecher()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Faecher", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Einen Lehrer in Tabellenform aus der Datenbank mit verschiedenen Suchparametern holen
        public DataTable GetOneFach(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Faecher WHERE CONCAT(FachID, Bezeichnung) LIKE '%{search}%'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Die ID eines Faches aus der Datenbank holen
        public int GetFachID(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT FachID FROM Faecher WHERE Bezeichnung = '{search}'", connection.GetConnection);

            connection.OpenConnection();
            int id = (int)command.ExecuteScalar();
            connection.CloseConnection();

            return id;
        }
    }
}
