using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementSystem.Data;



namespace ManagementSystem.Models
{
    public class Schueler
    {
        // Eigenschaften
        DBConnect connection = new DBConnect();


        // Schueler neu anlegen
        public bool InsertSchueler(string vorname, string nachname, DateTime geburtsdatum, string geschlecht, string telefonNr, string adresse, byte[] bild)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Schueler(Vorname, Nachname, Geburtsdatum, Geschlecht, TelefonNr, Adresse, Bild) " +
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

        // Schueler bearbeiten
        public bool UpdateSchueler(int id, string vorname, string nachname, DateTime geburtsdatum, string geschlecht, string telefonNr, string adresse, byte[] bild)
        {
            SqlCommand command = new SqlCommand("UPDATE Schueler " +
                                                "SET Vorname = @Vorname, Nachname = @Nachname, " +
                                                    "Geburtsdatum = @Geburtsdatum, Geschlecht = @Geschlecht, " +
                                                    "TelefonNr = @TelefonNr, Adresse = @Adresse, Bild = @Bild " +
                                                    "WHERE SchuelerID = @SchuelerID",
                                                  connection.GetConnection);

            command.Parameters.Add("@SchuelerID", SqlDbType.Int).Value = id;
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

        // Schueler entfernen
        public DataTable DeleteSchueler(string id)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Schueler WHERE SchuelerID = '{id}'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Alle Schueler in Tabellenform aus der Datenbank holen
        public DataTable GetAllSchueler()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Schueler", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            return table;
        }

        // Einen Schueler in Tabellenform aus der Datenbank mit verschiedenen Suchparametern holen
        public DataTable GetOneSchueler(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Schueler WHERE CONCAT(SchuelerID, Vorname, Nachname) LIKE '%{search}%'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        
        // Die Namen aller Schueler aus der Datenbank holen
        public DataTable GetSchuelerNames()
        {
            SqlCommand command = new SqlCommand("SELECT SchuelerID, Vorname, Nachname FROM Schueler", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Die Anzahl aller Schueler aus der Datenbank holen
        public string CountSchueler()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Schueler", connection.GetConnection);
            
            connection.OpenConnection();
            string count = command.ExecuteScalar().ToString();
            connection.CloseConnection();

            return count;
        }
    }
}
