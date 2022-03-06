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
    public class Note
    {
        // Eigenschaften
        DBConnect connection = new DBConnect();

        // Note neu vergeben
        public bool InsertNote(int schuelerID, int fachID, string wert, DateTime datum)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Noten(SchuelerID, FachID, Wert, Datum) " +
                                                    "VALUES (@SchuelerID, @FachID, @Wert, @Datum)",
                                                        connection.GetConnection);

            command.Parameters.Add("@SchuelerID", SqlDbType.Int).Value = schuelerID;
            command.Parameters.Add("@FachID", SqlDbType.Int).Value = fachID;
            command.Parameters.Add("@Wert", SqlDbType.VarChar).Value = wert;
            command.Parameters.Add("@Datum", SqlDbType.Date).Value = datum.Date;

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

        // Note bearbeiten
        public bool UpdateNote(int schuelerID, int fachID, string wert, DateTime datum)
        {
            SqlCommand command = new SqlCommand("UPDATE Noten " +
                                                "SET Wert = @Wert " +
                                                "WHERE SchuelerID = @SchuelerID AND FachID = @FachID AND Datum = @Datum",
                                                        connection.GetConnection);

            command.Parameters.Add("@SchuelerID", SqlDbType.Int).Value = schuelerID;
            command.Parameters.Add("@FachID", SqlDbType.Int).Value = fachID;
            command.Parameters.Add("@Wert", SqlDbType.VarChar).Value = wert;
            command.Parameters.Add("@Datum", SqlDbType.Date).Value = datum;

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

        // Note entfernen
        public bool DeleteNote(int schuelerID, int fachID, DateTime datum)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Noten " +
                                                "WHERE SchuelerID = @SchuelerID AND FachID = @FachID AND Datum = @Datum",
                                                        connection.GetConnection);

            command.Parameters.Add("@SchuelerID", SqlDbType.Int).Value = schuelerID;
            command.Parameters.Add("@FachID", SqlDbType.Int).Value = fachID;
            command.Parameters.Add("@Datum", SqlDbType.Date).Value = datum.Date;

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

        // Alle Lehrer in Tabellenform aus der Datenbank holen
        public DataTable GetAllNoten()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Noten", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Alle Noten ueber die SchuelerID aus der Datenbank holen
        public DataTable GetNotenBySchuelerID(string search)
        {
            SqlCommand command = new SqlCommand($"SELECT Noten.SchuelerID, Faecher.Bezeichnung, Noten.Wert, Noten.Datum" +
                                               $" FROM Noten " +
                                               $" INNER JOIN Faecher ON Noten.FachID = Faecher.FachID" +
                                               $" WHERE SchuelerID = '{search}'", connection.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }      
    }
}
