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
                System.Diagnostics.Process.Start("http://" + name + ".com");// Open website in default browser                
            }
            else
            {
                string message = "You must enter a website name!";// Error message
                string caption = "Error Detected in Input";// Error caption
                MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
            }

           
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            try
            {
              int num = 0;// Var
              int.TryParse(tbTextToAddToList.Text, out num);// Try to parse text to int
                if (num <= 0)
                {
                    string message = "Enter a number larger than 0";// Error message
                    string caption = "Error adding to list";// Error caption
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);// Show message
                }
                else
                {
                    listBoxNum.Items.Add(num);// Add value to list
                    tbTextToAddToList.Text = "";// Clear textbox
                }
               
            }
            catch (Exception ex)
            {
                string caption = "Error adding to list";// Error caption
                MessageBox.Show(ex.ToString(), caption, MessageBoxButtons.OK);// Show message
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBoxNum.Items.Clear();// Clear list
        }
 
    }
}
