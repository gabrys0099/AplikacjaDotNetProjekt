﻿namespace AplikacjaDotNetProjekt
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addMeal_button = new Button();
            addTraining_button = new Button();
            user_label = new Label();
            logOut_button = new Button();
            SuspendLayout();
            // 
            // addTraining_button
            // 
            addTraining_button.Location = new Point(570, 98);
            addTraining_button.Name = "addTraining_button";
            addTraining_button.Size = new Size(139, 55);
            addTraining_button.TabIndex = 1;
            addTraining_button.Text = "Add training";
            addTraining_button.UseVisualStyleBackColor = true;
            addTraining_button.Click += addTraining_button_Click;
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(41, 142);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(86, 45);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add a meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(41, 65);
            user_label.Name = "user_label";
            user_label.Size = new Size(29, 15);
            user_label.TabIndex = 3;
            user_label.Text = "user";
            // 
            // logOut_button
            // 
            logOut_button.Location = new Point(44, 239);
            logOut_button.Name = "logOut_button";
            logOut_button.Size = new Size(75, 23);
            logOut_button.TabIndex = 4;
            logOut_button.Text = "Log Out";
            logOut_button.UseVisualStyleBackColor = true;
            logOut_button.Click += logOut_button_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOut_button);
            Controls.Add(user_label);
            Controls.Add(addMeal_button);
            Controls.Add(addTraining_button);
            Name = "HomePage";
            Text = "Home Page";
            FormClosed += HomePage_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addTraining_button;
        private Button addMeal_button;
        private Label user_label;
        private Button logOut_button;
    }
}