using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ1_IGNACIO
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 go = new frm2(this);
            go.Show();
            

        }
        public void WriteTobutton(string inputText)
        {
            this.btnnull.Text = inputText;
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
