using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COUG_CHAT_Hackathon_2021
{
    
    
    //Random rd = new Random();
    //        string[] grades = { "Undergraduate", "Graduate" };
    //        string[] majors = { "Informatics", "Communications", "Computer Science", "Business", "Social Sciences" };
    //        string[] hobbies1 = { "Football", "Hiking", "Chess", "Video Games", "Fantasy Football" };
    //        string[] hobbies2 = { "Blogging", "Baking", "Catering", "Music", "Beekeeping", "Programming", "Tatooing" };
    //        string [] hobbies3 = {"Engraving", "Cheese", "Couponing", "Cycling", "Geneology", "Running", "Swimming", "Lifting", "Journaling", "Reading", "Singing"};
    //        string[] name = { "Nick Smith", "Evan Karaki", "Adam Robles", "Jose Zheng", "Michael Weller", "John Morgan", "Andy TheGoat" };
    //        //creating array of objects
    //        int arraySize = 7;
    //        accountInfo[] S = new accountInfo[7];

    //        int i = 0;

     
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
        string[] hobbies3 = { "Engraving", "Cheese", "Couponing", "Cycling", "Geneology", "Running", "Swimming", "Lifting", "Journaling", "Reading", "Singing" };
        string[] name = { "Nick Smith", "Evan Karaki", "Adam Robles", "Jose Zheng", "Michael Weller", "John Morgan", "Andy TheGoat" };
        //creating array of objects
        int arraySize = 7;
        accountInfo[] S = new accountInfo[7];
        bool[] friendsNames = new bool[7];
        int i = 0;

        int[]  friendTrackerArr = { 0,0,0,0,0,0,0 }; 
            
        

        private void viewAccountButton_Click(object sender, EventArgs e)
        {
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
                        if (S[0].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[0] = 1;
                        } else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;                        
                    case "Evan Karaki":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[1].getGrad();
                        hobbiesLabel.Text = S[1].getHobbies();
                        majorLabel.Text = S[1].getMajor();
                        if (S[1].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[1] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Adam Robles":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[2].getGrad();
                        hobbiesLabel.Text = S[2].getHobbies();
                        majorLabel.Text = S[2].getMajor();
                        if (S[2].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[2] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Jose Zheng":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[3].getGrad();
                        hobbiesLabel.Text = S[3].getHobbies();
                        majorLabel.Text = S[3].getMajor();

                        if (S[3].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[3] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }

                        break;
                    case "Michael Weller":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[4].getGrad();
                        hobbiesLabel.Text = S[4].getHobbies();
                        majorLabel.Text = S[4].getMajor();

                        if (S[4].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[4] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }

                        break;
                    case "John Morgan":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[5].getGrad();
                        hobbiesLabel.Text = S[5].getHobbies();
                        majorLabel.Text = S[5].getMajor();

                        if (S[5].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[5] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Andy TheGoat":
                        accountNameLabel.Text = selectedName;
                        studentTypeLabel.Text = S[6].getGrad();
                        hobbiesLabel.Text = S[6].getHobbies();
                        majorLabel.Text = S[6].getMajor();
                        
                        if (S[6].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[6] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                }
            }

            //Call the frind counter here

        }
        
        public int friendCounter()
        {

            int friendCounterVar = 0; 

            for(int i = 0; i < 7; i++)
            {
                if (friendTrackerArr[i] == 1)
                {
                    friendCounterVar++;
                    friendsNames[i] = true;
                }
            }

            return friendCounterVar;
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
        private void addFriendButton_Click(object sender, EventArgs e)
        {
            if (accountNamesListBox.SelectedIndex != -1)
            {
                string selectedName = accountNamesListBox.SelectedItem.ToString();

                switch (selectedName)
                {
                    case "Nick Smith":
                        S[0].friend = true;
                        if (S[0].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[0] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Evan Karaki":
                        S[1].friend = true;
                        if (S[1].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[1] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Adam Robles":
                        S[2].friend = true;
                        if (S[2].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[2] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Jose Zheng":
                        S[3].friend = true;
                        if (S[3].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[3] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Michael Weller":
                        S[4].friend = true;
                        if (S[4].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[4] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "John Morgan":

                        S[5].friend = true;
                        if (S[5].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[5] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                    case "Andy TheGoat":

                        S[6].friend = true;
                        if (S[6].friend)
                        {
                            friendLabel.Text = "Friends";
                            friendTrackerArr[6] = 1;
                        }
                        else
                        {
                            friendLabel.Text = "Not Friends";
                        }
                        break;
                }
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            int a = friendCounter();
            this.Close(); 
        }
        //public accountInfo[] accountStuff()
        //{
        //    return S;
        //}
        public bool[] friendsBoolean()
        {
            return friendsNames;
        }
        public string[] getAllNames()
        {
            return name;
        }
    }

    //public partial class friendForm: Form 
    
    //{
    //    public friendForm()
    //    {
    //        InitializeComponent();
    //    }

    //}
}