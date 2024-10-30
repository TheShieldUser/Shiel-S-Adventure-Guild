using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shiel_S_Adventure_Guild
{
    public partial class Form1 : Form
    {

        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string username = UsernameTexbox.Text;

            string password = PasswordTextbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                MessageBox.Show("Please Enter Something!");
            }

            if (username.ToLower() == "shielduser" && password.ToLower() == "q1234")
            {

                MessageBox.Show("Login Succesfully!");
            }
            else
            {
                MessageBox.Show("Invalid Input!");

            }
            UsernameTexbox.Text = string.Empty;
            PasswordTextbox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RUsernametextbox.Text) ||
                string.IsNullOrEmpty(rpasswordtextbox.Text) ||
                string.IsNullOrEmpty(ClassTextBox.Text))
            {
                MessageBox.Show("Please Enter Valid Item!");




            }


            User user = new(Username: RUsernametextbox.Text, Password: rpasswordtextbox.Text);
            users.Add(user);


            user.username = RUsernametextbox.Text;
            user.password = rpasswordtextbox.Text;


            MessageBox.Show("Register Succesfully!");

            RUsernametextbox.Text = string.Empty;
            rpasswordtextbox.Text = string.Empty;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTexbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
