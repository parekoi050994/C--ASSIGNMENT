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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        public frm2(frm1 frm1handler)
        {
            InitializeComponent();
            handletoform1 = frm1handler;
        }
        private frm1 handletoform1;


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
         
            int num = Convert.ToInt32(txtnum.Text);
            int num2 = Convert.ToInt32(lbResult.Text);
            int result = num2 + num;
            lbResult.Text = result.ToString();
           
            handletoform1.WriteTobutton(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
            int num = Convert.ToInt32(txtnum.Text);
            int num2 = Convert.ToInt32(lbResult.Text);
            int result = num2 - num;
            lbResult.Text = result.ToString();
           
            handletoform1.WriteTobutton(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnum_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
        }

        private void txtnum_MouseLeave(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                txtnum.Text = "0";
            }
        }

        private void txtnum_Validated(object sender, EventArgs e)
        {

        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
