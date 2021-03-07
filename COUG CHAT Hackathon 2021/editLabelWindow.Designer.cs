
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
            this.textBoxForEditing = new System.Windows.Forms.TextBox();
            this.enterButtonForEdit = new System.Windows.Forms.Button();
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
            this.enterButtonForEdit.Location = new System.Drawing.Point(129, 101);
            this.enterButtonForEdit.Name = "enterButtonForEdit";
            this.enterButtonForEdit.Size = new System.Drawing.Size(94, 29);
            this.enterButtonForEdit.TabIndex = 1;
            this.enterButtonForEdit.Text = "Enter";
            this.enterButtonForEdit.UseVisualStyleBackColor = true;
            this.enterButtonForEdit.Click += new System.EventHandler(this.enterButtonForEdit_Click);
            // 
            // editLabelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 153);
            this.Controls.Add(this.enterButtonForEdit);
            this.Controls.Add(this.textBoxForEditing);
            this.Name = "editLabelWindow";
            this.Text = "editLabelWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForEditing;
        private System.Windows.Forms.Button enterButtonForEdit;
    }
}