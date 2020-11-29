namespace veriyapilariproje
{
    partial class Form3
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeneyimsiz = new System.Windows.Forms.Button();
            this.deneyimTexBox = new System.Windows.Forms.TextBox();
            this.DilTexbox = new System.Windows.Forms.TextBox();
            this.ListBoxSorgu = new System.Windows.Forms.ListBox();
            this.elemanSayiLabel = new System.Windows.Forms.Label();
            this.derinlikLabel = new System.Windows.Forms.Label();
            this.listBoxPostOrder = new System.Windows.Forms.ListBox();
            this.listBoxPreOrder = new System.Windows.Forms.ListBox();
            this.listBoxInOrder = new System.Windows.Forms.ListBox();
            this.btnAgacElemanSayisiBul = new System.Windows.Forms.Button();
            this.btnAgacDerinlikBul = new System.Windows.Forms.Button();
            this.btnYabanciDilBilenler = new System.Windows.Forms.Button();
            this.btnEnAzIkıYılTecrube = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTumkisi = new System.Windows.Forms.Button();
            this.btnYas = new System.Windows.Forms.Button();
            this.btnEhliyet = new System.Windows.Forms.Button();
            this.ehliyettxt = new System.Windows.Forms.TextBox();
            this.yastxt = new System.Windows.Forms.TextBox();
            this.btnDosyaYaz = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDosyaYaz);
            this.tabPage3.Controls.Add(this.ehliyettxt);
            this.tabPage3.Controls.Add(this.yastxt);
            this.tabPage3.Controls.Add(this.btnEhliyet);
            this.tabPage3.Controls.Add(this.btnYas);
            this.tabPage3.Controls.Add(this.btnDeneyimsiz);
            this.tabPage3.Controls.Add(this.deneyimTexBox);
            this.tabPage3.Controls.Add(this.DilTexbox);
            this.tabPage3.Controls.Add(this.ListBoxSorgu);
            this.tabPage3.Controls.Add(this.elemanSayiLabel);
            this.tabPage3.Controls.Add(this.derinlikLabel);
            this.tabPage3.Controls.Add(this.listBoxPostOrder);
            this.tabPage3.Controls.Add(this.listBoxPreOrder);
            this.tabPage3.Controls.Add(this.listBoxInOrder);
            this.tabPage3.Controls.Add(this.btnAgacElemanSayisiBul);
            this.tabPage3.Controls.Add(this.btnAgacDerinlikBul);
            this.tabPage3.Controls.Add(this.btnYabanciDilBilenler);
            this.tabPage3.Controls.Add(this.btnEnAzIkıYılTecrube);
            this.tabPage3.Controls.Add(this.btnPostOrder);
            this.tabPage3.Controls.Add(this.btnInOrder);
            this.tabPage3.Controls.Add(this.btnPreOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(885, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kişileri Listele";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDeneyimsiz
            // 
            this.btnDeneyimsiz.Location = new System.Drawing.Point(430, 200);
            this.btnDeneyimsiz.Name = "btnDeneyimsiz";
            this.btnDeneyimsiz.Size = new System.Drawing.Size(283, 23);
            this.btnDeneyimsiz.TabIndex = 47;
            this.btnDeneyimsiz.Text = "Deneyimsiz Kişiler";
            this.btnDeneyimsiz.UseVisualStyleBackColor = true;
            this.btnDeneyimsiz.Click += new System.EventHandler(this.btnDeneyimsiz_Click);
            // 
            // deneyimTexBox
            // 
            this.deneyimTexBox.Location = new System.Drawing.Point(739, 116);
            this.deneyimTexBox.Name = "deneyimTexBox";
            this.deneyimTexBox.Size = new System.Drawing.Size(121, 20);
            this.deneyimTexBox.TabIndex = 42;
            // 
            // DilTexbox
            // 
            this.DilTexbox.Location = new System.Drawing.Point(739, 87);
            this.DilTexbox.Name = "DilTexbox";
            this.DilTexbox.Size = new System.Drawing.Size(121, 20);
            this.DilTexbox.TabIndex = 41;
            // 
            // ListBoxSorgu
            // 
            this.ListBoxSorgu.FormattingEnabled = true;
            this.ListBoxSorgu.Location = new System.Drawing.Point(430, 238);
            this.ListBoxSorgu.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxSorgu.Name = "ListBoxSorgu";
            this.ListBoxSorgu.Size = new System.Drawing.Size(283, 277);
            this.ListBoxSorgu.TabIndex = 40;
            // 
            // elemanSayiLabel
            // 
            this.elemanSayiLabel.AutoSize = true;
            this.elemanSayiLabel.Location = new System.Drawing.Point(736, 60);
            this.elemanSayiLabel.Name = "elemanSayiLabel";
            this.elemanSayiLabel.Size = new System.Drawing.Size(72, 13);
            this.elemanSayiLabel.TabIndex = 39;
            this.elemanSayiLabel.Text = "elaman sayisi:";
            // 
            // derinlikLabel
            // 
            this.derinlikLabel.AutoSize = true;
            this.derinlikLabel.Location = new System.Drawing.Point(736, 30);
            this.derinlikLabel.Name = "derinlikLabel";
            this.derinlikLabel.Size = new System.Drawing.Size(71, 13);
            this.derinlikLabel.TabIndex = 38;
            this.derinlikLabel.Text = "derinlik sayisi:";
            // 
            // listBoxPostOrder
            // 
            this.listBoxPostOrder.FormattingEnabled = true;
            this.listBoxPostOrder.Location = new System.Drawing.Point(250, 303);
            this.listBoxPostOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPostOrder.Name = "listBoxPostOrder";
            this.listBoxPostOrder.Size = new System.Drawing.Size(139, 212);
            this.listBoxPostOrder.TabIndex = 36;
            // 
            // listBoxPreOrder
            // 
            this.listBoxPreOrder.FormattingEnabled = true;
            this.listBoxPreOrder.Location = new System.Drawing.Point(92, 303);
            this.listBoxPreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPreOrder.Name = "listBoxPreOrder";
            this.listBoxPreOrder.Size = new System.Drawing.Size(139, 212);
            this.listBoxPreOrder.TabIndex = 37;
            // 
            // listBoxInOrder
            // 
            this.listBoxInOrder.FormattingEnabled = true;
            this.listBoxInOrder.Location = new System.Drawing.Point(182, 50);
            this.listBoxInOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxInOrder.Name = "listBoxInOrder";
            this.listBoxInOrder.Size = new System.Drawing.Size(152, 186);
            this.listBoxInOrder.TabIndex = 35;
            // 
            // btnAgacElemanSayisiBul
            // 
            this.btnAgacElemanSayisiBul.Location = new System.Drawing.Point(430, 55);
            this.btnAgacElemanSayisiBul.Name = "btnAgacElemanSayisiBul";
            this.btnAgacElemanSayisiBul.Size = new System.Drawing.Size(283, 23);
            this.btnAgacElemanSayisiBul.TabIndex = 34;
            this.btnAgacElemanSayisiBul.Text = "Ağacın Eleman Sayısını Bul";
            this.btnAgacElemanSayisiBul.UseVisualStyleBackColor = true;
            this.btnAgacElemanSayisiBul.Click += new System.EventHandler(this.btnAgacElemanSayisiBul_Click);
            // 
            // btnAgacDerinlikBul
            // 
            this.btnAgacDerinlikBul.Location = new System.Drawing.Point(430, 20);
            this.btnAgacDerinlikBul.Name = "btnAgacDerinlikBul";
            this.btnAgacDerinlikBul.Size = new System.Drawing.Size(283, 23);
            this.btnAgacDerinlikBul.TabIndex = 32;
            this.btnAgacDerinlikBul.Text = "Ağacın Derinliğini Bul";
            this.btnAgacDerinlikBul.UseVisualStyleBackColor = true;
            this.btnAgacDerinlikBul.Click += new System.EventHandler(this.btnAgacDerinlikBul_Click);
            // 
            // btnYabanciDilBilenler
            // 
            this.btnYabanciDilBilenler.Location = new System.Drawing.Point(430, 84);
            this.btnYabanciDilBilenler.Name = "btnYabanciDilBilenler";
            this.btnYabanciDilBilenler.Size = new System.Drawing.Size(283, 23);
            this.btnYabanciDilBilenler.TabIndex = 31;
            this.btnYabanciDilBilenler.Text = "Yabancı Dil Bilenlere Göre Listele";
            this.btnYabanciDilBilenler.UseVisualStyleBackColor = true;
            this.btnYabanciDilBilenler.Click += new System.EventHandler(this.btnYabanciDilBilenler_Click);
            // 
            // btnEnAzIkıYılTecrube
            // 
            this.btnEnAzIkıYılTecrube.Location = new System.Drawing.Point(430, 113);
            this.btnEnAzIkıYılTecrube.Name = "btnEnAzIkıYılTecrube";
            this.btnEnAzIkıYılTecrube.Size = new System.Drawing.Size(283, 23);
            this.btnEnAzIkıYılTecrube.TabIndex = 30;
            this.btnEnAzIkıYılTecrube.Text = "Tecrübeli Elemanları Listele En Az :";
            this.btnEnAzIkıYılTecrube.UseVisualStyleBackColor = true;
            this.btnEnAzIkıYılTecrube.Click += new System.EventHandler(this.btnEnAzIkıYılTecrube_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(250, 275);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(139, 23);
            this.btnPostOrder.TabIndex = 29;
            this.btnPostOrder.Text = "Postorder Listele";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(182, 20);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(139, 23);
            this.btnInOrder.TabIndex = 27;
            this.btnInOrder.Text = "Inorder Listele";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(92, 275);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(139, 23);
            this.btnPreOrder.TabIndex = 25;
            this.btnPreOrder.Text = "Preorder Listele";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnTumkisi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 545);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Sorgular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 318);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnTumkisi
            // 
            this.btnTumkisi.Location = new System.Drawing.Point(84, 26);
            this.btnTumkisi.Name = "btnTumkisi";
            this.btnTumkisi.Size = new System.Drawing.Size(75, 23);
            this.btnTumkisi.TabIndex = 42;
            this.btnTumkisi.Text = "Tüm Kişiler";
            this.btnTumkisi.UseVisualStyleBackColor = true;
            this.btnTumkisi.Click += new System.EventHandler(this.btnTumkisi_Click);
            // 
            // btnYas
            // 
            this.btnYas.Location = new System.Drawing.Point(430, 142);
            this.btnYas.Name = "btnYas";
            this.btnYas.Size = new System.Drawing.Size(283, 23);
            this.btnYas.TabIndex = 48;
            this.btnYas.Text = "Yas getir";
            this.btnYas.UseVisualStyleBackColor = true;
            this.btnYas.Click += new System.EventHandler(this.btnYas_Click);
            // 
            // btnEhliyet
            // 
            this.btnEhliyet.Location = new System.Drawing.Point(430, 171);
            this.btnEhliyet.Name = "btnEhliyet";
            this.btnEhliyet.Size = new System.Drawing.Size(283, 23);
            this.btnEhliyet.TabIndex = 49;
            this.btnEhliyet.Text = "Ehliyet getir";
            this.btnEhliyet.UseVisualStyleBackColor = true;
            this.btnEhliyet.Click += new System.EventHandler(this.btnEhliyet_Click);
            // 
            // ehliyettxt
            // 
            this.ehliyettxt.Location = new System.Drawing.Point(739, 174);
            this.ehliyettxt.Name = "ehliyettxt";
            this.ehliyettxt.Size = new System.Drawing.Size(121, 20);
            this.ehliyettxt.TabIndex = 51;
            // 
            // yastxt
            // 
            this.yastxt.Location = new System.Drawing.Point(739, 145);
            this.yastxt.Name = "yastxt";
            this.yastxt.Size = new System.Drawing.Size(121, 20);
            this.yastxt.TabIndex = 50;
            // 
            // btnDosyaYaz
            // 
            this.btnDosyaYaz.Location = new System.Drawing.Point(721, 238);
            this.btnDosyaYaz.Name = "btnDosyaYaz";
            this.btnDosyaYaz.Size = new System.Drawing.Size(139, 23);
            this.btnDosyaYaz.TabIndex = 52;
            this.btnDosyaYaz.Text = "Listelenen dosya yaz";
            this.btnDosyaYaz.UseVisualStyleBackColor = true;
            this.btnDosyaYaz.Click += new System.EventHandler(this.btnDosyaYaz_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 571);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgacElemanSayisiBul;
        private System.Windows.Forms.Button btnAgacDerinlikBul;
        private System.Windows.Forms.Button btnYabanciDilBilenler;
        private System.Windows.Forms.Button btnEnAzIkıYılTecrube;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.ListBox listBoxInOrder;
        private System.Windows.Forms.ListBox listBoxPostOrder;
        private System.Windows.Forms.ListBox listBoxPreOrder;
        private System.Windows.Forms.Label derinlikLabel;
        private System.Windows.Forms.Label elemanSayiLabel;
        private System.Windows.Forms.TextBox DilTexbox;
        private System.Windows.Forms.ListBox ListBoxSorgu;
        private System.Windows.Forms.TextBox deneyimTexBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTumkisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeneyimsiz;
        private System.Windows.Forms.TextBox ehliyettxt;
        private System.Windows.Forms.TextBox yastxt;
        private System.Windows.Forms.Button btnEhliyet;
        private System.Windows.Forms.Button btnYas;
        private System.Windows.Forms.Button btnDosyaYaz;
    }
}

