namespace veriyapilariproje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnSirket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(117, 245);
            this.btnPersonel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(105, 51);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "PERSONEL";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnSirket
            // 
            this.btnSirket.Location = new System.Drawing.Point(390, 245);
            this.btnSirket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSirket.Name = "btnSirket";
            this.btnSirket.Size = new System.Drawing.Size(103, 51);
            this.btnSirket.TabIndex = 3;
            this.btnSirket.Text = "ŞİRKET";
            this.btnSirket.UseVisualStyleBackColor = true;
            this.btnSirket.Click += new System.EventHandler(this.btnSirket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSirket);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnSirket;
    }
}