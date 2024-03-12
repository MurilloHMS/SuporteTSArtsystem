namespace WinFormsApp1.UI
{
    partial class Finder
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
            groupBox1 = new GroupBox();
            LB_Finder = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LB_Finder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busca";
            // 
            // LB_Finder
            // 
            LB_Finder.Dock = DockStyle.Fill;
            LB_Finder.FormattingEnabled = true;
            LB_Finder.ItemHeight = 15;
            LB_Finder.Location = new Point(3, 19);
            LB_Finder.Name = "LB_Finder";
            LB_Finder.Size = new Size(415, 473);
            LB_Finder.TabIndex = 0;
            LB_Finder.SelectedIndexChanged += LB_Finder_SelectedIndexChanged;
            LB_Finder.DoubleClick += LB_Finder_DoubleClick;
            // 
            // Finder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 519);
            Controls.Add(groupBox1);
            Name = "Finder";
            Text = "Finder";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox LB_Finder;
    }
}