using Microsoft.VisualBasic.ApplicationServices;

namespace الواجب_الثاني
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private User user1;
        private List<User> users;
        private void Form1_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "Zaid Alnajar";
            user1.Username = "ZA";
            user1.Password = "1234";

            users = new List<User>(); // We created the actual object for the list of users

            users.Add(user1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user1.Username != txtUsername.Text)
            {
                MessageBox.Show("User does not exist");
            }
            else
            {
                if (user1.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user1.FullName);
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
        }
    }
}