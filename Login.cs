using Azure;

namespace Assignment4_C_
{
    public partial class Login : Form
    {
        private Operations o = new Operations();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpass.Text;

            int userId = o.checkUser(username, password);

            if (userId != 0)
            {
                TransactionHistoryClass form = new TransactionHistoryClass(userId);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
