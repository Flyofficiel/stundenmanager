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
    public partial class mainmenü : UserControl
    {
        public mainmenü()
        {
            InitializeComponent();
        }

        private void mainmenü_Load(object sender, EventArgs e)
        {
            getlehrer();
        }
        private void getlehrer()
        {
            string connstring = "Server=127.0.0.1;Uid=root;Pwd=;Database=stundenmanager";
            string commandgetlehrer = "SELECT * FROM lehrer";

            try
            {
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(commandgetlehrer, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var table = new DataTable();
                            table.Load(reader); 
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Lehrerliste: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
