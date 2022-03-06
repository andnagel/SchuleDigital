using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.Data;



namespace ManagementSystem.Models
{
    public class Lehrer
    {
        // Eigenschaften
        DBConnect connection = new DBConnect();


        // Lehrer neu anlegen
        public bool InsertLehrer(string vorname, string nachname, DateTime geburtsdatum, string geschlecht, string telefonNr, string adresse, byte[] bild)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Lehrer(Vorname, Nachname, Geburtsdatum, Geschlecht, TelefonNr, Adresse, Bild) " +
                                                    "VALUES (@Vorname, @Nachname, @Geburtsdatum, @Geschlecht, @TelefonNr, @Adresse, @Bild)",
                                                        connection.GetConnection);

            command.Parameters.Add("@Vorname", SqlDbType.VarChar).Value = vorname;
            command.Parameters.Add("@Nachname", SqlDbType.VarChar).Value = nachname;
            command.Parameters.Add("@Geburtsdatum", SqlDbType.Date).Value = geburtsdatum.Date;
            command.Parameters.Add("@Geschlecht", SqlDbType.VarChar).Value = geschlecht;
            command.Parameters.Add("@TelefonNr", SqlDbType.VarChar).Value = telefonNr;
            command.Parameters.Add("@Adresse", SqlDbType.Text).Value = adresse;
            command.Parameters.Add("@Bild", SqlDbType.Image).Value = bild;


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

        // Lehrer bearbeiten
        public bool UpdateLehrer(int id, string vorname, string nachname, DateTime geburtsdatum, string geschlecht, string telefonNr, string adresse, byte[] bild)
        {
            SqlCommand command = new SqlCommand("UPDATE Lehrer " +
                                                "SET Vorname = @Vorname, Nachname = @Nachname, " +
                                                    "Geburtsdatum = @Geburtsdatum, Geschlecht = @Geschlecht, " +
                                                    "TelefonNr = @TelefonNr, Adresse = @Adresse, Bild = @Bild " +
                                                    "WHERE PersID = @PersID",
                                                  connection.GetConnection);

            command.Parameters.Add("@PersID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Vorname", SqlDbType.VarChar).Value = vorname;
            command.Parameters.Add("@Nachname", SqlDbType.VarChar).Value = nachname;
            command.Parameters.Add("@Geburtsdatum", SqlDbType.Date).Value = geburtsdatum.Date;
            command.Parameters.Add("@Geschlecht", SqlDbType.VarChar).Value = geschlecht;
            command.Parameters.Add("@TelefonNr", SqlDbType.VarChar).Value = telefonNr;
            command.Parameters.Add("@Adresse", SqlDbType.Text).Value = adresse;
            command.Parameters.Add("@Bild", SqlDbType.Image).Value = bild;


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

        // Lehrer entfernen
        public DataTable DeleteLehrer(string id)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Lehrer WHERE PersID = '{id}'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Alle Lehrer in Tabellenform aus der Datenbank holen
        public DataTable GetAllLehrer()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Lehrer", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Einen Lehrer in Tabellenform aus der Datenbank mit verschiedenen Suchparametern holen
        public DataTable GetOneLehrer(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Lehrer WHERE CONCAT(PersID, Vorname, Nachname) LIKE '%{search}%'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Die ID eines Lehrers aus der Datenbank holen
        public int? GetLehrerID(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT PersID FROM Lehrer WHERE CONCAT(PersID, Vorname, Nachname) LIKE '%{search}%'", connection.GetConnection);
            int? id = null;
            try
            {
                connection.OpenConnection();
                id = (int?)command.ExecuteScalar();
                connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;
        }

        // Den Namen eines Lehrers aus der Datenabnk holen
        public string GetLehrerName(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT Nachname FROM Lehrer WHERE PersID = '{search}'", connection.GetConnection);
            string name = "";
            try
            {
                connection.OpenConnection();
                name = (string)command.ExecuteScalar();
                connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return name;
        }

        // Die Anzahl aller Lehrer aus der Datenbank holen
        public string CountLehrer()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Lehrer", connection.GetConnection);

            connection.OpenConnection();
            string count = command.ExecuteScalar().ToString();
            connection.CloseConnection();

            return count;
        }
    }
}
