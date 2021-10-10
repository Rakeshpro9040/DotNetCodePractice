using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class DummyForm : Form
    {
        public DummyForm()
        {
            InitializeComponent();
        }

        private void DummyForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_dummy_Click(object sender, EventArgs e)
        {
            lbl_dummy.Text = "Button Clicked!";
            lbl_dummy.ForeColor = Color.Black;
        }

        private void btn_changecolor_Click(object sender, EventArgs e)
        {
            lbl_dummy.ForeColor = Color.Red;
        }
    }
}
