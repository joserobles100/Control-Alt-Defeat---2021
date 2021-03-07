using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;   //Used for writing to file 
using System.Windows.Forms;
using System.IO;                //Used for writing to file 

namespace COUG_CHAT_Hackathon_2021
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }
        
        //Constants
        //const string USERNAME = "j";
        //const string PASSWORD = "a";
        private void signInButton_Click(object sender, EventArgs e)
        {

            //TESTING   
            StreamReader infile =  File.OpenText("accountInfo.txt");

            string USERNAME = infile.ReadLine(); 
            string PASSWORD = infile.ReadLine(); 



            string newUserName = "";
            string newPassword = "";
           
            newUserName = userNameTextBox.Text;
            newPassword = passwordTextBox.Text;

            if (newUserName == USERNAME && newPassword == PASSWORD)
            {
                //Create an instance of the profileWindow gui
                profileWindow myProfile = new profileWindow();
                
                myProfile.ShowDialog(); 
                //this.Close(); 
            }
            else
                MessageBox.Show("Login info incorrect");
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            createAccountForm myAccountForm = new createAccountForm();

            myAccountForm.ShowDialog(); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
