using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COUG_CHAT_Hackathon_2021
{
    public partial class discoverPeopleForm : Form
    {
        public discoverPeopleForm()
        {
            InitializeComponent();
        }
 

            Random rd = new Random();
            string[] grades = { "Undergraduate", "Graduate" };
            string[] majors = { "Informatics", "Communications", "Computer Science", "Business", "Social Sciences" };
            string[] hobbies1 = { "Football", "Hiking", "Chess", "Video Games", "Fantasy Football" };
            string[] hobbies2 = { "Blogging", "Baking", "Catering", "Music", "Beekeeping", "Programming", "Tatooing" };
            string [] hobbies3 = {"Engraving", "Cheese", "Couponing", "Cycling", "Geneology", "Running", "Swimming", "Lifting", "Journaling", "Reading", "Singing"};
            string[] name = { "Nick Smith", "Evan Karaki", "Adam Robles", "Jose Zheng", "Michael Weller", "John Morgan", "Andy TheGoat" };
            //creating array of objects
            int arraySize = 7;
            accountInfo[] S = new accountInfo[7];

            int i = 0;

            
        private void viewAccountButton_Click(object sender, EventArgs e)
        {
           //declareArray(); 


            if (accountNamesListBox.SelectedIndex != -1)
            {
                string selectedName = accountNamesListBox.SelectedItem.ToString();



                switch(selectedName)
                {
                   
                    case "Nick Smith":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[0].getGrad();
                        hobbiesLabel.Text = S[0].getHobbies();
                        majorLabel.Text = S[0].getMajor();
                        break;                        
                    case "Evan Karaki":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[1].getGrad();
                        hobbiesLabel.Text = S[1].getHobbies();
                        majorLabel.Text = S[1].getMajor();
                        break;
                    case "Adam Robles":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[2].getGrad();
                        hobbiesLabel.Text = S[2].getHobbies();
                        majorLabel.Text = S[2].getMajor();
                        break;
                    case "Jose Zheng":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[3].getGrad();
                        hobbiesLabel.Text = S[3].getHobbies();
                        majorLabel.Text = S[3].getMajor();
                        break;
                    case "Michael Weller":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[4].getGrad();
                        hobbiesLabel.Text = S[4].getHobbies();
                        majorLabel.Text = S[4].getMajor();
                        break;
                    case "John Morgan":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[5].getGrad();
                        hobbiesLabel.Text = S[5].getHobbies();
                        majorLabel.Text = S[5].getMajor();
                        break;
                    case "Andy TheGoat":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[6].getGrad();
                        hobbiesLabel.Text = S[6].getHobbies();
                        majorLabel.Text = S[6].getMajor();
                        break;
                }
            }

        }
    
        public void declareArray()
        {
            //initlising objects by detauls/inbuilt constructors
            for (int i = 0; i < arraySize; i++)
            {
                S[i] = new accountInfo(name[i], grades[rd.Next(0, grades.Length - 1)],
                    "Hobbies: " + hobbies1[rd.Next(0, hobbies1.Length - 1)] + "\n\t" + hobbies2[rd.Next(0, hobbies2.Length - 1)] + "\n\t" + hobbies3[rd.Next(0, hobbies3.Length - 1)], 
                    majors[rd.Next(0, majors.Length - 1)]);
            }          
       }


        private void discoverPeopleForm_Load(object sender, EventArgs e)
        {
            declareArray();
            for (i = 0; i < arraySize; i++)
            {
                //string name = S.getName(); 
                accountNamesListBox.Items.Add(S[i].getName());

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
