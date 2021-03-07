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
    public partial class createAccountForm : Form
    {
        public createAccountForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            

            string username = "";
            string password = "";
            string name = "";
            string major = "";
            string graduate = "";
            string hobbies = "";

            username = userBox.Text;
            password = passText.Text;
            name = nameText.Text;
            major = majorText.Text;
            graduate = gradBox.Text; 
            hobbies = hobText.Text;

            // StreamWriter outfile = File.AppendText("accountInfo.txt");

            //StreamWriter outfile = new StreamWriter(@"c:\Temp\accountInfo.txt");

            //  StreamWriter outfile = new StreamWriter("C:\\accountInfo.txt");

            //@"C:\Users\18jos\Documents\Visual Studio 2019\Hackathon 2019\COUG CHAT Hackathon 2021\bin\accountInfo.txt"

            // using (StreamWriter outfile = File.AppendText("accountInfo.txt"))
            //{

            //StreamWriter outfile = File.AppendText("accountInfo.txt");

            //C:\Users\18jos\Documents\Visual Studio 2019\Hackathon 2019\COUG CHAT Hackathon 2021

           //StreamWriter outfile = File.CreateText("C:\Users\18jos\Documents\Visual Studio 2019\Hackathon 2019\COUG CHAT Hackathon 2021\accountInfo.txt");
            using var outfile = new StreamWriter("accountInfo.txt");
            outfile.WriteLine(username);
                outfile.WriteLine(password);
                outfile.WriteLine(name);
                outfile.WriteLine(graduate);
                outfile.WriteLine(hobbies);
                outfile.WriteLine(major);
                outfile.Close();
            //}


            this.Close();

            //Create instance of the form
            profileWindow myProfileWindow = new profileWindow();

            myProfileWindow.ShowDialog();


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
