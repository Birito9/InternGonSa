namespace CallAPI
{
    partial class MainForm
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
            uC_NhanVien1 = new UC_NhanVien();
            SuspendLayout();
            // 
            // uC_NhanVien1
            // 
            uC_NhanVien1.Dock = DockStyle.Fill;
            uC_NhanVien1.Location = new Point(0, 0);
            uC_NhanVien1.Name = "uC_NhanVien1";
            uC_NhanVien1.Size = new Size(1384, 762);
            uC_NhanVien1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 762);
            Controls.Add(uC_NhanVien1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UC_NhanVien uC_NhanVien1;
    }
}