using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stundenmanager
{
    public partial class loginform : Form
    {
        public loginform()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hauptControl = new mainmenü(); // bleibt UserControl
            var hostForm = new Form
            {
                Text = "Hauptmenü",
                StartPosition = FormStartPosition.CenterScreen,
                Width = 1044, // optional anpassen
                Height = 546
            };
            hauptControl.Dock = DockStyle.Fill;
            hostForm.Controls.Add(hauptControl);


            string username = usernameinput.Text;
            string passwort = passwortinput.Text;
            string connstring = "Server=127.0.0.1;Uid=root;Pwd=;Database=stundenmanager";
            string commandlogin = "SELECT * FROM lehrer WHERE vorname = @username AND pdw = @password";

            using (var conn = new MySqlConnection(connstring))
            {
                try
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
                                
                                

                                this.Hide();
                                hostForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Username oder Passwort falsch!", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler bei der Datenbankverbindung: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            



        }
    }
}
