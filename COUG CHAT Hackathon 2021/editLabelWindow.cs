using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COUG_CHAT_Hackathon_2021
{
    public partial class editLabelWindow : Form
    {
        public editLabelWindow()
        {
            InitializeComponent();
        }

        public void enterButtonForEdit_Click(object sender, EventArgs e)
        {
            string newInput = textBoxForEditing.Text;
            this.Close(); 
        }

        public string returnTheNewString ()
        {
            return textBoxForEditing.Text; 
        }
    }
}
