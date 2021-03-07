
namespace COUG_CHAT_Hackathon_2021
{
    partial class discoverPeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountNamesListBox = new System.Windows.Forms.ListBox();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.studentTypeLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.viewAccountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNamesListBox
            // 
            this.accountNamesListBox.FormattingEnabled = true;
            this.accountNamesListBox.ItemHeight = 20;
            this.accountNamesListBox.Location = new System.Drawing.Point(49, 40);
            this.accountNamesListBox.Name = "accountNamesListBox";
            this.accountNamesListBox.Size = new System.Drawing.Size(265, 244);
            this.accountNamesListBox.TabIndex = 3;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.BackColor = System.Drawing.Color.White;
            this.accountNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNameLabel.ForeColor = System.Drawing.Color.Black;
            this.accountNameLabel.Location = new System.Drawing.Point(462, 40);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(159, 25);
            this.accountNameLabel.TabIndex = 6;
            // 
            // studentTypeLabel
            // 
            this.studentTypeLabel.BackColor = System.Drawing.Color.White;
            this.studentTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.studentTypeLabel.Location = new System.Drawing.Point(462, 89);
            this.studentTypeLabel.Name = "studentTypeLabel";
            this.studentTypeLabel.Size = new System.Drawing.Size(159, 25);
            this.studentTypeLabel.TabIndex = 7;
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.BackColor = System.Drawing.Color.White;
            this.hobbiesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hobbiesLabel.ForeColor = System.Drawing.Color.Black;
            this.hobbiesLabel.Location = new System.Drawing.Point(462, 134);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(159, 68);
            this.hobbiesLabel.TabIndex = 8;
            // 
            // majorLabel
            // 
            this.majorLabel.BackColor = System.Drawing.Color.White;
            this.majorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.majorLabel.ForeColor = System.Drawing.Color.Black;
            this.majorLabel.Location = new System.Drawing.Point(462, 216);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(159, 25);
            this.majorLabel.TabIndex = 9;
            // 
            // viewAccountButton
            // 
            this.viewAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewAccountButton.ForeColor = System.Drawing.Color.White;
            this.viewAccountButton.Location = new System.Drawing.Point(49, 301);
            this.viewAccountButton.Name = "viewAccountButton";
            this.viewAccountButton.Size = new System.Drawing.Size(108, 37);
            this.viewAccountButton.TabIndex = 10;
            this.viewAccountButton.Text = "View account ";
            this.viewAccountButton.UseVisualStyleBackColor = false;
            this.viewAccountButton.Click += new System.EventHandler(this.viewAccountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(547, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 37);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Back";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // discoverPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(691, 359);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewAccountButton);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.studentTypeLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountNamesListBox);
            this.Name = "discoverPeopleForm";
            this.Text = "discoverPeopleForm";
            this.Load += new System.EventHandler(this.discoverPeopleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox accountNamesListBox;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label graduate;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Button viewAccountButton;
        private System.Windows.Forms.Label studentTypeLabel;
        private System.Windows.Forms.Button exitButton;
    }
}