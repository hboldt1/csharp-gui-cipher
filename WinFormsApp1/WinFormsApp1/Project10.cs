/**
* Cipher.java
* Hudson Boldt / Lab Section 02B | Thu 4:30
* 
* This class is the Contoller an view in MVC. It handles all of the gui and view operations.
* 
* EXTRA CREDIT
* 
*/

namespace WinFormsApp1
{
    public partial class Project10 : Form
    {
        public Project10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {// get key
        }
        private void message_box_TextChanged(object sender, EventArgs e)
        {// get message

        }

        private void label1_Click(object sender, EventArgs e)
        {// enter key

        }
        private void message_label_Click(object sender, EventArgs e)
        {// enter message

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            encrypt_label.Text = "";
            decrypt_label.Text = "";
        }

        private void Go_Click(object sender, EventArgs e)
        {


            int key = 0;
            bool validInput = false;

            
            string input = key_box.Text;
            try
            {

                key = int.Parse(input);

                if (key >= 0 && key <= 25)
                {
                    validInput = true;
                }
                else
                {
                    encrypt_label.Text = "ERROR: KEY must be between 0 and 25 (inclusive)";
                    decrypt_label.Text = "Please CLEAR and try again";
                }

            }
            catch (FormatException)
            {
                encrypt_label.Text = "ERROR: Invalid input. KEY must be an integer";
                decrypt_label.Text = "Please CLEAR and try again";

            }


            if (validInput)
            {
                string message = message_box.Text;

                Cipher cipher = new Cipher(key, message);

                cipher.Encrypt();
                encrypt_label.Text = cipher.ToString();
                cipher.Decrypt();
                decrypt_label.Text = cipher.ToString();
            }

        }

        

        
    }
}
