using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stundenmanager
{
    internal class dbconn
    {



        public static void logindatabase(string username, string passwort)
        {
            string connstring = "Server=127.0.0.1;Uid=root;Pwd=root;Database=stundenmanager";
            string commandlogin = "SELECT * FROM lehrer WHERE vorname = @username AND pdw = @password";

            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(commandlogin, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwort);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login erfolgreich! Willkommen zurück.", "Erfolg");
                        }
                        else
                        {
                            MessageBox.Show("Username oder Passwort falsch!", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public static void getlehrer()
        {
            string connstring = "Server=127.0.0.1;Uid=root;Pwd=root;Database=stundenmanager";
            string commandgetlehrer = "SELECT * FROM lehrer";
            var conn = new MySqlConnection(connstring);
            var cmd = new MySqlCommand(commandgetlehrer, conn);
            
        }
    }
}

