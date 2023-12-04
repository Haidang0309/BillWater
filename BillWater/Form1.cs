using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BillWater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string Username = tbUsername.Text;
            string Password = tbPassword.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter username and password.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ManagerBill managerBill = new ManagerBill();
            managerBill.Show();
        }
    }
}