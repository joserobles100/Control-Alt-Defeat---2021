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
    public partial class profileWindow : Form
    {
        public profileWindow()
        {
            InitializeComponent();
        }

        private void nameEditButton_Click(object sender, EventArgs e)
        {
            //Create instance of the editLabel form
            editLabelWindow myEditWindow = new editLabelWindow();
            myEditWindow.ShowDialog();
            nameLabel.Text = myEditWindow.returnTheNewString();
        }

        private void editGradButton_Click(object sender, EventArgs e)
        {
            editLabelWindow myEditWindow = new editLabelWindow();
            myEditWindow.ShowDialog();
            studentTypeLabel.Text = myEditWindow.returnTheNewString(); 
        }

        private void editHobbyButton_Click(object sender, EventArgs e)
        {
            editLabelWindow myEditWindow = new editLabelWindow();
            myEditWindow.ShowDialog();
            hobbyLabel.Text = "Hobbies: " + myEditWindow.returnTheNewString();
        }

        private void editMajorButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the profileWindow gui
            editLabelWindow myEditWindow = new editLabelWindow();
            myEditWindow.ShowDialog();
            majorLabel.Text ="Major: " + myEditWindow.returnTheNewString(); 
        }
        
        public string returnStringForEditing(string newData)
        {
            return newData; 
        }

        private void discoverButton_Click(object sender, EventArgs e)
        {
            //Random rd = new Random();
            //string[] grades = { "Undergraduate", "Graduate" };

            ////creating array of objects
            //accountInfo[] S = new accountInfo[2];
            ////initlising objects by detauls/inbuilt constructors
            //S[0] = new accountInfo("Henry Dough", grades[rd.Next(0, 1)], "Hobbies: Football\n\tHiking\n\tChess", "Informatics");
            //S[1] = new accountInfo("Damon Hill", grades[rd.Next(0, 1)], "Hobbies: Football\n\tHiking\n\tChess", "Informatics");


            //accountInfo accounts = new accountInfo[4];
            //accountInfo[0] = new accountInfo("Evan", "Freshman", "Fantasy Football", "Computer Science");

            discoverPeopleForm discoverPeopleWindow = new discoverPeopleForm();
            discoverPeopleWindow.ShowDialog();

            int followerCounter = discoverPeopleWindow.friendCounter();
            followerLabel.Text = "Friends: " + followerCounter;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
           
            //signInForm mySignIn = new signInForm();
            this.Close();
            //mySignIn.ShowDialog(); 
            
        }


        //This is for when we create an account and we can overwrite the data already there
        private void profileWindow_Load(object sender, EventArgs e)
        {

            followerLabel.Text = "Friends: 0";

            StreamReader infile = File.OpenText("accountInfo.txt");

            //discoverPeopleForm myPeopleForm = new discoverPeopleForm(); 
            f.Text = "Go Cougs!";
            string buffer = "";
            userNameLabel.Text = infile.ReadLine();
            buffer = infile.ReadLine();
            nameLabel.Text = infile.ReadLine();
            studentTypeLabel.Text = infile.ReadLine();
            hobbyLabel.Text = "Hobbies: " + infile.ReadLine();
            majorLabel.Text = "Major: " + infile.ReadLine();
            //int followerCounter = myPeopleForm.friendCounter();
            //followerLabel.Text = "Friends: " + followerCounter; 
 
            //TESTING THIS WAS COMMENTED ORIGINALLY
            infile.Close();
        }

        private void viewFriendsButton_Click(object sender, EventArgs e)
        {
            friendForm myFriendForm = new friendForm();

            myFriendForm.ShowDialog(); 
        }
        //private void majorLabel_Click(object sender, EventArgs e)
        //{

        //}
    }
}
