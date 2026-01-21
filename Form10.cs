using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceCollect
{
    public partial class Form10 : Form
    {
        private int currentViewerId;

        public Form10(int viewerId)
        {
            InitializeComponent();
            currentViewerId = viewerId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11(currentViewerId);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

       

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form10_Load_1(object sender, EventArgs e)
        {

        }
    }
}