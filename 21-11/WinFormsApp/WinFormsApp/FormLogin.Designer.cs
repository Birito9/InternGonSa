using System.Windows.Forms;
using System;

namespace WinFormsApp
{
    partial class FormLogin
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            form_Login1 = new UC_Login();
            SuspendLayout();
            // 
            // form_Login1
            // 
            form_Login1.Dock = DockStyle.Fill;
            form_Login1.Location = new Point(0, 0);
            form_Login1.Name = "form_Login1";
            form_Login1.Size = new Size(1013, 720);
            form_Login1.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1013, 720);
            Controls.Add(form_Login1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
        }

        #endregion

        private UC_Login form_Login1;
    }
}
