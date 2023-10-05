namespace GUI_NhanVien
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            uc_QuanLyNhanVien1 = new GUI_QuanLyNhanVien.uc_QuanLyNhanVien();
            SuspendLayout();
            // 
            // uc_QuanLyNhanVien1
            // 
            uc_QuanLyNhanVien1.Dock = DockStyle.Fill;
            uc_QuanLyNhanVien1.Location = new Point(0, 0);
            uc_QuanLyNhanVien1.Name = "uc_QuanLyNhanVien1";
            uc_QuanLyNhanVien1.Size = new Size(1040, 617);
            uc_QuanLyNhanVien1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 617);
            Controls.Add(uc_QuanLyNhanVien1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Quản Lý Nhân Viên";
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private GUI_QuanLyNhanVien.uc_QuanLyNhanVien uc_QuanLyNhanVien1;
    }
}
