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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(DateTime.Now), "Добро пожаловать");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //если нажали на кнопку "Закрыть" 
            {
                if (MessageBox.Show("Точно ли вы хотите закрыть окно?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void task2Button_Click(object sender, EventArgs e)
        {
            SampleForm sample = new SampleForm();
            sample.Show();
        }

        private void task3Button_Click(object sender, EventArgs e)
        {
            ChromakeyForm chromakey = new ChromakeyForm();
            chromakey.Show();
        }

        private void task4Button_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
        }
    }
}
