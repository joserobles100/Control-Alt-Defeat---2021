using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace COUG_CHAT_Hackathon_2021
{
    public partial class friendForm : Form
    {

        public friendForm()
        {
            InitializeComponent();
        }
        private void friendForm_Load(object sender, EventArgs e)
        {
            //discoverPeopleForm myDiscoverForm = new discoverPeopleForm();

            profileWindow myProfile = new profileWindow();


            friendListBox.Items.Add("Andy TheGoat");
            friendListBox.Items.Add("Evan Karaki");
            friendListBox.Items.Add("Jose Zheng");
        }

        private void viewPersonButton_Click(object sender, EventArgs e)
        {
            if (friendListBox.SelectedIndex != -1)
            {
                string selectedName = friendListBox.SelectedItem.ToString();
                switch (selectedName)
                {
                    case "Andy TheGoat":
                        SFMLabel.Text = "Andy TheGoat";
                        break;
                    case "Evan Karaki":
                        SFMLabel.Text = "Evan Karaki";
                        break;
                    case "Jose Zheng":
                        SFMLabel.Text = "Jose Zheng";
                        break;
                }

            }
        }

      




        //ADD RANDOM RESPONSES  
        private void hiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hiRadioButton.Checked)
            {
                string[] responses = { "Hi!", "Hello!", "Hey!", "What's Up!", "Greetings!" };
                Random rd = new Random();
                hiLabel.Text = responses[rd.Next(0, responses.Length - 1)];
            }
        }

        private void howRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (howRadioButton.Checked)
            {
                string[] responses = {"I'm good thank you", "Great!", "Awesome!", "I'm good thanks!", "poggers"};
                Random rd = new Random();
                howLabel.Text = responses[rd.Next(0, responses.Length - 1)];
            }
            
        }

        private void byeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (byeRadioButton.Checked)
            {
                string[] responses = { "See ya too!", "Ok see ya!", "Okay.", "Aye fam", "see ya bro ", "You're still here? " };
                Random rd = new Random();
                byeLabel.Text = responses[rd.Next(0, responses.Length - 1)];
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

