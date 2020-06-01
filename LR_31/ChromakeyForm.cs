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
    public partial class ChromakeyForm : SampleForm
    {
        public ChromakeyForm()
        {
            InitializeComponent();
        }

        private void ChromakeyForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "Задание№3";
            label1.Text = Convert.ToString(DateTime.Now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now);
        }
    }
}
