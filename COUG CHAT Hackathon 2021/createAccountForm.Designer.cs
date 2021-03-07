
namespace COUG_CHAT_Hackathon_2021
{
    partial class createAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createAccountForm));
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.gradBox = new System.Windows.Forms.TextBox();
            this.hobText = new System.Windows.Forms.TextBox();
            this.majorText = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradLabel = new System.Windows.Forms.Label();
            this.hobLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(568, 309);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(133, 60);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(568, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 56);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(212, 60);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(239, 27);
            this.userBox.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(212, 113);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(238, 27);
            this.passText.TabIndex = 3;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(212, 164);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(237, 27);
            this.nameText.TabIndex = 4;
            // 
            // gradBox
            // 
            this.gradBox.Location = new System.Drawing.Point(213, 208);
            this.gradBox.Name = "gradBox";
            this.gradBox.Size = new System.Drawing.Size(238, 27);
            this.gradBox.TabIndex = 5;
            // 
            // hobText
            // 
            this.hobText.Location = new System.Drawing.Point(213, 260);
            this.hobText.Name = "hobText";
            this.hobText.Size = new System.Drawing.Size(238, 27);
            this.hobText.TabIndex = 6;
            // 
            // majorText
            // 
            this.majorText.Location = new System.Drawing.Point(213, 309);
            this.majorText.Name = "majorText";
            this.majorText.Size = new System.Drawing.Size(238, 27);
            this.majorText.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(33, 60);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(78, 20);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(33, 113);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(70, 20);
            this.passLabel.TabIndex = 9;
            this.passLabel.Text = "Password";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(33, 164);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            // 
            // gradLabel
            // 
            this.gradLabel.AutoSize = true;
            this.gradLabel.ForeColor = System.Drawing.Color.White;
            this.gradLabel.Location = new System.Drawing.Point(33, 211);
            this.gradLabel.Name = "gradLabel";
            this.gradLabel.Size = new System.Drawing.Size(111, 20);
            this.gradLabel.TabIndex = 11;
            this.gradLabel.Text = "Graduate Level:";
            // 
            // hobLabel
            // 
            this.hobLabel.AutoSize = true;
            this.hobLabel.ForeColor = System.Drawing.Color.White;
            this.hobLabel.Location = new System.Drawing.Point(33, 260);
            this.hobLabel.Name = "hobLabel";
            this.hobLabel.Size = new System.Drawing.Size(68, 20);
            this.hobLabel.TabIndex = 12;
            this.hobLabel.Text = "Hobbies:";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.ForeColor = System.Drawing.Color.White;
            this.majorLabel.Location = new System.Drawing.Point(33, 311);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(51, 20);
            this.majorLabel.TabIndex = 13;
            this.majorLabel.Text = "Major:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // createAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(706, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.hobLabel);
            this.Controls.Add(this.gradLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.majorText);
            this.Controls.Add(this.hobText);
            this.Controls.Add(this.gradBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Name = "createAccountForm";
            this.Text = "createAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox gradBox;
        private System.Windows.Forms.TextBox hobText;
        private System.Windows.Forms.TextBox majorText;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradLabel;
        private System.Windows.Forms.Label hobLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}