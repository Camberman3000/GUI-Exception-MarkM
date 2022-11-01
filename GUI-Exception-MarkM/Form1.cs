/**
MS-539 - Fall 2022
Mark Montenieri
Week 2 assignment - Basic GUI and Exception 
Estimated time to complete - 1hr

The project took longer than expected, mostly because I wanted to make it look
a bit nicer, even though my UI skills are marginal, at best. (It's on my todo list...)
It also took me a bit longer to make the try/catch fail. Turns out, it was
TryParse vs. Parse. I'm still trying to get used to switching languages,
since most of my work the past year has been in C++ (Unreal Engine specific).
Either way, I think the program works, and fails as intended.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI_Exception_MarkM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Mark M. GUI & Exception Handling ";// Window Title
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);// Center form on screen
        }

        private void btn_OpenBrowser_Click(object sender, EventArgs e)
        {
            string name = "";// Var
            name = tbWebsiteName.Text;// Assign textbox value

            if (name != "")
            {
                if (name.All(Char.IsLetterOrDigit))// Check for all alphanumeric
                {
                    System.Diagnostics.Process.Start("http://" + name + ".com");// Open website in default browser  
                }
                else
                {
                    string message = "Invalid website name! Must be letters and numbers only.";// Error message
                    string caption = "Error Detected in Input";// Msgbox caption
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
                }                             
            }
            else
            {               
                string message = "You must enter a website name!";// Error message
                string caption = "Error Detected in Input";// Msgbox caption
                MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
            }           
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {           
            try
            {                
                int num = int.Parse(tbTextToAddToList.Text);// Parse to int - NOTE: TryParse would work better here but for exception demo I'm using Parse
                listBoxNum.Items.Add(num);// Add to list
                tbTextToAddToList.Text = "";// Clear textbox for next entry
                tbTextToAddToList.Focus();// Focus
            }
            catch (Exception ex)
            {
                string caption = "Error adding to list";// Msgbox caption
                MessageBox.Show(ex.ToString(), caption, MessageBoxButtons.OK);// Show message
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBoxNum.Items.Clear();// Clear list
        }

        private void buttonGoHome_Click(object sender, EventArgs e)
        {
            if (comboBoxBunch.SelectedIndex == -1)// No selection?
            {
                string message = "You 'aven't picked any bananas, Mon.";// Error message
                string caption = "No bunches";// Msgbox caption
                MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
            }
            else
            {
                if (radioButtonDay.Checked)
                {
                    string message = "Come Mr. Tally man, tally me banana, daylight come and me wanna go home.";// Error message
                    string caption = "Work finished";// Msgbox caption
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
                }
                else if (radioButtonNight.Checked)
                {
                    string bunchSize = comboBoxBunch.SelectedItem.ToString();
                    string message = "You've only picked a single " + bunchSize + " bunch." + " Get back to work, Mon!";
                    string caption = "Work not finished";// Msgbox caption
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
                }
                else
                {
                    string message = "What time is it?";// Error message
                    string caption = "You're drunk on rum";// Msgbox caption
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
                }
            }         
        }
    }
}
