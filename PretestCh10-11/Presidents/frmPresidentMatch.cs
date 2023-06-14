using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presidents
{
    public partial class frmPresidentMatch : Form
    {
        public frmPresidentMatch()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        //  Global arrays
        string[] firstNames =
        {
            "Franklin",
            "Harry",
            "Dwight",
            "John F.",
            "Lyndon",
            "Richard",
            "Gerald",
            "Jimmy",
            "Ronald",
            "George H.W.",
            "Bill",
            "George W.",
            "Barack",
            "Donald",
            "Joe"
        };

        string[] lastNames =
        {
            "Roosevelt",
            "Truman",
            "Eisenhower",
            "Kennedy",
            "Johnson",
            "Nixon",
            "Ford",
            "Carter",
            "Reagan",
            "Bush",
            "Clinton",
            "Bush",
            "Obama",
            "Trump",
            "Biden"
        };

        string[] party =
        {
            "Democrat",
            "Democrat",
            "Republican",
            "Democrat",
            "Democrat",
            "Republican",
            "Republican",
            "Democrat",
            "Republican",
            "Republican",
            "Democrat",
            "Republican",
            "Democrat",
            "Republican",
            "Democrat"
        };

        //	NOTE: 	You will have to change the path on all of
        //			these image files to reflect your location
        //			of said images!
        string[] images =
        {
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/32-franklinroosevelt.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/33-harrytruman.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/34-dwighteisenhower.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/35-johnkennedy.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/36-lyndonjohnson.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/37-richardnixon.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/38-geraldford.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/39-jimmycarter.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/40-ronaldreagan.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/41-georgehwbush.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/42-billclinton.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/43-georgewwbush.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/44-barackobama.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/45-donaldtrump.jpg",
            "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/46-joebiden.jpg"
        };

        //	NOTE: 	Same with this image file.
        string noImageAvailable = "C:/Users/jpscott/Desktop/Chapters9-11Pretest/PretestCh10-11/Presidents/Images/00-nia.jpg";


        private void frmPresidentMatch_Load(object sender,
                                            EventArgs e)
        {
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            for (int lcv = 0; lcv < firstNames.Length; ++lcv)
            {
                //  Fill up and display the first name combobox
                ddlFirstName.Items.Add(firstNames[lcv]);

                //  Fil up and display the last name combobox
                ddlLastName.Items.Add(lastNames[lcv]);
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            bool  keepGoing = CheckForNoFirstNameChosen();

            if (keepGoing)
            {
                //  This means there was a ComboBox first name entry chosen
                keepGoing = CheckForNoLastNameChosen();
            }

            if (keepGoing)
            {
                //  Check for first nane/last name match, i.e. do
                //  both reference the same array element location.
                CheckForMatch();
            }
        }

        private bool CheckForNoFirstNameChosen()
        {
            bool retVal = true;

            if (ddlFirstName.SelectedIndex == -1)
            {
                ShowMessage("No First Name Selected!!!",
                            "NO FIRST NAME");
                retVal = false;
            }

            return retVal;
        }

        private bool CheckForNoLastNameChosen()
        {
            bool retVal = true;

            if (ddlLastName.SelectedIndex == -1)
            {
                ShowMessage("No Last Name Selected!!!",
                            "NO LAST NAME");
                retVal = false;
            }

            return retVal;
        }

        private void CheckForMatch()
        {
            //  Check for first name/last name/same array element location
            //  In other words, if both ComboBoxes are referencing the
            //  same array element locale, there was a match. If this is
            //  the case, fill in the PictureBox with the associated image.
            if ((ddlFirstName.SelectedIndex == ddlLastName.SelectedIndex) ||
                ((ddlFirstName.Text == "George H.W.") || (ddlFirstName.Text == "George W.") &&
                (ddlLastName.Text == "Bush")))
            {
                pbPresidentImage.Image =
                    System.Drawing.Image.FromFile(images[ddlFirstName.SelectedIndex]);

            //  Set the appropriate political affiliation for
            //  the selected President.
            string polAffiliation = party[ddlFirstName.SelectedIndex];

                switch (polAffiliation)
                {
                    case "Democrat":
                        rbDemocrat.Checked = true;
                        break;

                    case "Republican":
                        rbRepublican.Checked = true;
                        break;

                    case "Independent":
                        rbIndependent.Checked = true;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                //  There was no match
                pbPresidentImage.Image =
                    System.Drawing.Image.FromFile(noImageAvailable);
            }

            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (5);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ClearAll();
        }

        private void btnGoToMainForm_Click(object sender, EventArgs e)
        {
            GoToMainForm();
        }

        private void GoToMainForm()
        {
            //  Hide the current form
            this.Hide();

            //  Instantiate (create) a new Play the Game Form
            frmMain main = new frmMain();

            //   Show the Play the Game Form
            main.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            ClearComboBoxText();
            ClearPictureBoxImage();
            ClearRadioButtonsChecked();
        }

        private void ClearComboBoxText()
        {
            ddlFirstName.SelectedIndex = -1;
            ddlLastName.SelectedIndex  = -1;
        }

        private void ClearPictureBoxImage()
        {
            pbPresidentImage.Image = null;
        }

        private void ClearRadioButtonsChecked()
        {
            rbDemocrat.Checked    = false;
            rbRepublican.Checked  = false;
            rbIndependent.Checked = false;
            GoToMainForm();
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
                Close();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
