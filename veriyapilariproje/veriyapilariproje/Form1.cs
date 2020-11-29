using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriyapilariproje
{
    public partial class Form1 : Form
    {

        public static IkiliAramaAgaci ikiliagac = new IkiliAramaAgaci();
       
        public Form1()
        {
             
            InitializeComponent();
            
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();           
           // JsonReadWrite.JsonToTree();
            form2.Show();
        }

        private void btnSirket_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonReadWrite.JsonToTree();
        }
    }
}
