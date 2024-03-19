using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static Mini_Project_Management_System.authenticate;  // Importing static members from the authenticate class
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Project_Management_System
{
    public partial class CarWash : Form
    {
        private User authenticatedUser;

        public CarWash(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
        }

        private void CarWash_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=CarWash; Integrated Security=True;"))
            {
                bool a = false;
                bool b = false;
                bool c = false;
                bool d = false;

                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Services WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (Services.SelectedItem != null)
                {
                    a = true;
                    conditions.Add("service = @service");
                }

                if (timeService.SelectedItem != null)
                {
                    b = true;
                    conditions.Add("timeService = @timeService");
                }

                if (Price.SelectedItem != null)
                {
                    c = true;
                    conditions.Add("price = @price");
                }

                if (productQuality.SelectedItem != null)
                {
                    d = true;
                    conditions.Add("productQuality = @productQuality");
                }

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (a)
                    cmd.Parameters.AddWithValue("@service", Services.SelectedItem.ToString());
                if (b)
                    cmd.Parameters.AddWithValue("@timeService", timeService.SelectedItem.ToString());
                if (c)
                    cmd.Parameters.AddWithValue("@price", Price.SelectedItem.ToString());
                if (d)
                    cmd.Parameters.AddWithValue("@productQuality", productQuality.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Services.SelectedIndex = -1;
            timeService.SelectedIndex = -1;
            productQuality.SelectedIndex = -1;
            Price.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (booking userInputForm = new booking())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }
    }
}
