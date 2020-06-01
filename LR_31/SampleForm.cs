using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_31
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void styleButton_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White && ForeColor == Color.Black)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
            else 
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
        }
    }
}
