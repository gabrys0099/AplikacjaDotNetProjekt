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
            addMeasurement_button = new Button();
            SuspendLayout();
            // 
            // addMeal_button
            // 
            addMeal_button.Location = new Point(47, 189);
            addMeal_button.Margin = new Padding(3, 4, 3, 4);
            addMeal_button.Name = "addMeal_button";
            addMeal_button.Size = new Size(98, 60);
            addMeal_button.TabIndex = 2;
            addMeal_button.Text = "Add a meal";
            addMeal_button.UseVisualStyleBackColor = true;
            addMeal_button.Click += addMeal_button_Click;
            // 
            // addTraining_button
            // 
            addTraining_button.Location = new Point(743, 119);
            addTraining_button.Margin = new Padding(3, 4, 3, 4);
            addTraining_button.Name = "addTraining_button";
            addTraining_button.Size = new Size(159, 73);
            addTraining_button.TabIndex = 1;
            addTraining_button.Text = "Add training";
            addTraining_button.UseVisualStyleBackColor = true;
            addTraining_button.Click += addTraining_button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(47, 87);
            user_label.Name = "user_label";
            user_label.Size = new Size(36, 20);
            user_label.TabIndex = 3;
            user_label.Text = "user";
            // 
            // logOut_button
            // 
            logOut_button.Location = new Point(50, 319);
            logOut_button.Margin = new Padding(3, 4, 3, 4);
            logOut_button.Name = "logOut_button";
            logOut_button.Size = new Size(86, 31);
            logOut_button.TabIndex = 4;
            logOut_button.Text = "Log Out";
            logOut_button.UseVisualStyleBackColor = true;
            logOut_button.Click += logOut_button_Click;
            // 
            // addMeasurement_button
            // 
            addMeasurement_button.Location = new Point(758, 224);
            addMeasurement_button.Name = "addMeasurement_button";
            addMeasurement_button.Size = new Size(144, 41);
            addMeasurement_button.TabIndex = 5;
            addMeasurement_button.Text = "Add measurement";
            addMeasurement_button.UseVisualStyleBackColor = true;
            addMeasurement_button.Click += addMeasurement_button_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(addMeasurement_button);
            Controls.Add(logOut_button);
            Controls.Add(user_label);
            Controls.Add(addMeal_button);
            Controls.Add(addTraining_button);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button addMeasurement_button;
    }
}