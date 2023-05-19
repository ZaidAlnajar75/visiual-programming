using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCountry.Items.Add("Jordan");
            cmbCountry.Items.Add("libnan");
            cmbCountry.Items.Add("Almaghreb");
            cmbCountry.Items.Add("tonis");
        }
        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = cmbCountry.SelectedItem.ToString();
            if (selectedCountry == "Jordan")
            {
                cmbCity.Items.AddRange(new string[] { "shona", "salt" });
            }
            else if (selectedCountry == "libnan")
            {
                cmbCity.Items.AddRange(new string[] { "bairut", "afqa" });
            }
            else if (selectedCountry == "Almaghreb")
            {
                cmbCity.Items.AddRange(new string[] { "fas", "tanja"});
            }
            else if (selectedCountry == "tonis")
            {
                cmbCity.Items.AddRange(new string[] { "aljaresa", "thureat" });
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int nationalnumber;
            string gender;
            string skills = "";
            string name;
            string Country;
            string City;
            nationalnumber = Convert.ToInt32(txtNationalNumber.Text);
            name = txtName.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;
            if (age >= 22)
            {
                dateOfBirth = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Your age is not allowed to register");
            }
            Country = cmbCountry.Text;

            string country = cmbCountry.SelectedItem.ToString();
            City = cmbCity.Text;
            if (rbtnMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (chbxprogramming.Checked == true)
                skills += chbxprogramming.Text + "\n";

            if (chbxwebdesign.Checked == true)
                skills += chbxwebdesign.Text + "\n";

            if (chbxUI_UX.Checked == true)
                skills += chbxUI_UX.Text + "\n";
            MessageBox.Show("\n National Number: " + nationalnumber + "\n Name: " + name + "\n Date of Birth: " + dateOfBirth + "\n Country of residence: " + Country + "\n City: " + City + "\n Gender: " + gender + "\n Skills: " + skills);
        }
    }
}