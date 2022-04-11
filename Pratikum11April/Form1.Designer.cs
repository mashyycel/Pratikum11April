
namespace Pratikum11April
{
    partial class FormHasilPertandingan
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
            this.cBoxTimHome = new System.Windows.Forms.ComboBox();
            this.cBoxTimLawan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblManagerTimHome = new System.Windows.Forms.Label();
            this.lblCaptainTimHome = new System.Windows.Forms.Label();
            this.lblManagerTimLawan = new System.Windows.Forms.Label();
            this.lblCaptainTimLawan = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxTimHome
            // 
            this.cBoxTimHome.FormattingEnabled = true;
            this.cBoxTimHome.Location = new System.Drawing.Point(22, 30);
            this.cBoxTimHome.Name = "cBoxTimHome";
            this.cBoxTimHome.Size = new System.Drawing.Size(295, 24);
            this.cBoxTimHome.TabIndex = 0;
            this.cBoxTimHome.SelectedIndexChanged += new System.EventHandler(this.cBoxTimHome_SelectedIndexChanged);
            // 
            // cBoxTimLawan
            // 
            this.cBoxTimLawan.FormattingEnabled = true;
            this.cBoxTimLawan.Location = new System.Drawing.Point(457, 30);
            this.cBoxTimLawan.Name = "cBoxTimLawan";
            this.cBoxTimLawan.Size = new System.Drawing.Size(295, 24);
            this.cBoxTimLawan.TabIndex = 1;
            this.cBoxTimLawan.SelectedIndexChanged += new System.EventHandler(this.cBoxTimLawan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Captain:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Captain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manager:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stadium:";
            // 
            // lblManagerTimHome
            // 
            this.lblManagerTimHome.AutoSize = true;
            this.lblManagerTimHome.Location = new System.Drawing.Point(105, 97);
            this.lblManagerTimHome.Name = "lblManagerTimHome";
            this.lblManagerTimHome.Size = new System.Drawing.Size(46, 17);
            this.lblManagerTimHome.TabIndex = 9;
            this.lblManagerTimHome.Text = "label8";
            // 
            // lblCaptainTimHome
            // 
            this.lblCaptainTimHome.AutoSize = true;
            this.lblCaptainTimHome.Location = new System.Drawing.Point(105, 134);
            this.lblCaptainTimHome.Name = "lblCaptainTimHome";
            this.lblCaptainTimHome.Size = new System.Drawing.Size(46, 17);
            this.lblCaptainTimHome.TabIndex = 10;
            this.lblCaptainTimHome.Text = "label9";
            // 
            // lblManagerTimLawan
            // 
            this.lblManagerTimLawan.AutoSize = true;
            this.lblManagerTimLawan.Location = new System.Drawing.Point(528, 97);
            this.lblManagerTimLawan.Name = "lblManagerTimLawan";
            this.lblManagerTimLawan.Size = new System.Drawing.Size(54, 17);
            this.lblManagerTimLawan.TabIndex = 11;
            this.lblManagerTimLawan.Text = "label10";
            // 
            // lblCaptainTimLawan
            // 
            this.lblCaptainTimLawan.AutoSize = true;
            this.lblCaptainTimLawan.Location = new System.Drawing.Point(528, 134);
            this.lblCaptainTimLawan.Name = "lblCaptainTimLawan";
            this.lblCaptainTimLawan.Size = new System.Drawing.Size(54, 17);
            this.lblCaptainTimLawan.TabIndex = 12;
            this.lblCaptainTimLawan.Text = "label11";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(344, 240);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(54, 17);
            this.lblStadium.TabIndex = 13;
            this.lblStadium.Text = "label12";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(344, 277);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(54, 17);
            this.lblCapacity.TabIndex = 14;
            this.lblCapacity.Text = "label13";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblCaptainTimLawan);
            this.Controls.Add(this.lblManagerTimLawan);
            this.Controls.Add(this.lblCaptainTimHome);
            this.Controls.Add(this.lblManagerTimHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxTimLawan);
            this.Controls.Add(this.cBoxTimHome);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTimHome;
        private System.Windows.Forms.ComboBox cBoxTimLawan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblManagerTimHome;
        private System.Windows.Forms.Label lblCaptainTimHome;
        private System.Windows.Forms.Label lblManagerTimLawan;
        private System.Windows.Forms.Label lblCaptainTimLawan;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblCapacity;
    }
}

