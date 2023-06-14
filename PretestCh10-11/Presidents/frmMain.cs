using System;
using System.Windows.Forms;

namespace Presidents
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            //  Declare and build output string that goes
            //  in the txtInstructions.Text textbox.
            string outputStr = "";
            outputStr += "Choose a first name and a last name from each of the ComboBoxes.\r\n\r\n"; ;
            outputStr += "Then click the Match button to see whether or not you are correct.\r\n\r\n";
            outputStr += "To keep the game simple, only the last 15 US President images are shown.";

            //  Put outputStr text into txtInstructions.Text textbox.
            txtInstructions.Text = outputStr;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            ShowThePlayTheGameForm();
        }

        private void ShowThePlayTheGameForm()
        {
            //  Hide the current form
            this.Hide();

            //  Instantiate (create) a new Play the Game Form
            frmPresidentMatch pm = new frmPresidentMatch();

            //   Show the Play the Game Form
            pm.ShowDialog();
        }

        private void ShowCheckBoxButtonsSelected()
        {
            //  This will contain 0 or more of the social media things
            string selected = "";

            if (cbFacebook.Checked)
            {
                //  Following on Facebook
                selected += cbFacebook.Text + " ";
            }

            if (cbInstagram.Checked)
            {
                //  Following on Instagram
                selected += cbInstagram.Text + " ";
            }

            if (cbTwitter.Checked)
            {
                //  Following on Twitter
                selected += cbTwitter.Text + " ";
            }

            //  If one or more checkboxes are checked
            //  show a MessageBox with the appropriate
            //  checked checkbox values shown.
            if (selected.Trim() != "")
            {
                MessageBox.Show("You Currently Follow Us On: " +
                                selected, "SOCIAL MEDIA PRESENCE",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);    
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                            "Do You Really Want To Exit?",
                            "EXIT NOW?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ShowCheckBoxButtonsSelected();
                Application.Exit();
            }
        }
     }
}
