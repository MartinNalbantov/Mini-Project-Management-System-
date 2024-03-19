using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mini_Project_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon;
        public Form1()
        {
            InitializeComponent();

        }
        private void LogInForm_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=CompanyManagement; Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string pass = Password.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                authenticate.User authenticatedUser = authenticate.DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    CarWash welcome = new CarWash(authenticatedUser);
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
