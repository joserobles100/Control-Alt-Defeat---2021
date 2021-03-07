
namespace COUG_CHAT_Hackathon_2021
{
    partial class editLabelWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editLabelWindow));
            this.textBoxForEditing = new System.Windows.Forms.TextBox();
            this.enterButtonForEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxForEditing
            // 
            this.textBoxForEditing.Location = new System.Drawing.Point(94, 58);
            this.textBoxForEditing.Name = "textBoxForEditing";
            this.textBoxForEditing.Size = new System.Drawing.Size(153, 27);
            this.textBoxForEditing.TabIndex = 0;
            // 
            // enterButtonForEdit
            // 
            this.enterButtonForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.enterButtonForEdit.ForeColor = System.Drawing.Color.White;
            this.enterButtonForEdit.Location = new System.Drawing.Point(129, 101);
            this.enterButtonForEdit.Name = "enterButtonForEdit";
            this.enterButtonForEdit.Size = new System.Drawing.Size(94, 29);
            this.enterButtonForEdit.TabIndex = 1;
            this.enterButtonForEdit.Text = "Enter";
            this.enterButtonForEdit.UseVisualStyleBackColor = false;
            this.enterButtonForEdit.Click += new System.EventHandler(this.enterButtonForEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter new data: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // editLabelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(346, 153);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterButtonForEdit);
            this.Controls.Add(this.textBoxForEditing);
            this.Name = "editLabelWindow";
            this.Text = "editLabelWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForEditing;
        private System.Windows.Forms.Button enterButtonForEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}