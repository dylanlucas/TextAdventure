namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.mainRichTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRichTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.mainRichTextBox.Location = new System.Drawing.Point(4, 12);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mainRichTextBox.Size = new System.Drawing.Size(599, 401);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.userInputTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.userInputTextBox.Location = new System.Drawing.Point(12, 430);
            this.userInputTextBox.Multiline = true;
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(501, 29);
            this.userInputTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(524, 430);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 29);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(615, 544);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.mainRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button enterButton;
    }
}

