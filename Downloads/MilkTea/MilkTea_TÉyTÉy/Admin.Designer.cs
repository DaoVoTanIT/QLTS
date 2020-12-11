namespace MilkTea_TâyTây
{
    partial class Admin
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
            this.tbcRevenue = new System.Windows.Forms.TabControl();
            this.tpRevenue = new System.Windows.Forms.TabPage();
            this.tpStaff = new System.Windows.Forms.TabPage();
            this.tbcRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRevenue
            // 
            this.tbcRevenue.Controls.Add(this.tpRevenue);
            this.tbcRevenue.Controls.Add(this.tpStaff);
            this.tbcRevenue.Location = new System.Drawing.Point(0, 2);
            this.tbcRevenue.Name = "tbcRevenue";
            this.tbcRevenue.SelectedIndex = 0;
            this.tbcRevenue.Size = new System.Drawing.Size(805, 448);
            this.tbcRevenue.TabIndex = 0;
            // 
            // tpRevenue
            // 
            this.tpRevenue.Location = new System.Drawing.Point(4, 25);
            this.tpRevenue.Name = "tpRevenue";
            this.tpRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tpRevenue.Size = new System.Drawing.Size(797, 419);
            this.tpRevenue.TabIndex = 0;
            this.tpRevenue.Text = "Doanh thu";
            this.tpRevenue.UseVisualStyleBackColor = true;
            // 
            // tpStaff
            // 
            this.tpStaff.Location = new System.Drawing.Point(4, 25);
            this.tpStaff.Name = "tpStaff";
            this.tpStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tpStaff.Size = new System.Drawing.Size(797, 419);
            this.tpStaff.TabIndex = 1;
            this.tpStaff.Text = "Nhân viên";
            this.tpStaff.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcRevenue);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tbcRevenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRevenue;
        private System.Windows.Forms.TabPage tpRevenue;
        private System.Windows.Forms.TabPage tpStaff;
    }
}