﻿namespace Gym_Management_System.pages.admin
{
    partial class AdminDashboard
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
            this.pnlAdminDashboard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(12, 12);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(776, 426);
            this.pnlAdminDashboard.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminDashboard;
    }
}