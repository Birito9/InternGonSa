namespace DesignerCode
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
            uC_TrangThaiGiaoHang1 = new GUI.UC_TrangThaiGiaoHang();
            SuspendLayout();
            // 
            // uC_TrangThaiGiaoHang1
            // 
            uC_TrangThaiGiaoHang1.Dock = DockStyle.Fill;
            uC_TrangThaiGiaoHang1.Location = new Point(0, 0);
            uC_TrangThaiGiaoHang1.Name = "uC_TrangThaiGiaoHang1";
            uC_TrangThaiGiaoHang1.Size = new Size(1165, 801);
            uC_TrangThaiGiaoHang1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 801);
            Controls.Add(uC_TrangThaiGiaoHang1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GUI.UC_TrangThaiGiaoHang uC_TrangThaiGiaoHang1;
    }
}