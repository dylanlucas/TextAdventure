﻿namespace CH8P1
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
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textBoxRiddle = new System.Windows.Forms.TextBox();
            this.riddleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputTextBox.Location = new System.Drawing.Point(12, 452);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(487, 29);
            this.userInputTextBox.TabIndex = 1;
            this.userInputTextBox.Text = "look";
            this.userInputTextBox.TextChanged += new System.EventHandler(this.userInputTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(523, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 37);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.mainRichTextBox.Enabled = false;
            this.mainRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(586, 424);
            this.mainRichTextBox.TabIndex = 2;
            this.mainRichTextBox.Text = "";
            // 
            // textBoxRiddle
            // 
            this.textBoxRiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRiddle.Location = new System.Drawing.Point(186, 495);
            this.textBoxRiddle.Name = "textBoxRiddle";
            this.textBoxRiddle.Size = new System.Drawing.Size(412, 29);
            this.textBoxRiddle.TabIndex = 2;
            this.textBoxRiddle.Visible = false;
            // 
            // riddleLabel
            // 
            this.riddleLabel.AutoSize = true;
            this.riddleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riddleLabel.Location = new System.Drawing.Point(9, 495);
            this.riddleLabel.Name = "riddleLabel";
            this.riddleLabel.Size = new System.Drawing.Size(148, 16);
            this.riddleLabel.TabIndex = 4;
            this.riddleLabel.Text = "Enter Riddle Answer";
            this.riddleLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 559);
            this.Controls.Add(this.riddleLabel);
            this.Controls.Add(this.textBoxRiddle);
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userInputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.TextBox textBoxRiddle;
        private System.Windows.Forms.Label riddleLabel;
    }
}

