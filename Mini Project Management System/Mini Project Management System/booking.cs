using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_Management_System
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {

        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=CarWash; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                
                string insertQuery = "INSERT INTO Bookings(name, number, service, serviceTime, productQuality, date) VALUES (@Service,@sTime, @pQuality, @gName, @pNumber, @bDate)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                // Set parameters based on selected values
                insertCmd.Parameters.AddWithValue("@Service", Services.SelectedItem);
                insertCmd.Parameters.AddWithValue("@gName", Name.Text);
                insertCmd.Parameters.AddWithValue("@pNumber", Number.Text);
                insertCmd.Parameters.AddWithValue("@sTime", comboBox2.SelectedItem);
                insertCmd.Parameters.AddWithValue("@pQuality", comboBox3.SelectedItem);
                insertCmd.Parameters.AddWithValue("@bDate", bookingDate.Value);

                insertCmd.ExecuteNonQuery();


                MessageBox.Show("Booking Successful!");
   
            }
        }
    }
}
