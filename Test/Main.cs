using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            label1.Text = "Здравствуйте, выберите интересующий вас тест";
            btnProg.Text = "Программирование";
            btnMaths.Text = "Математика";
            btnPhis.Text = "Физика";
            btnClose.Text = "Выход";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
