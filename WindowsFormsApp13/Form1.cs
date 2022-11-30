using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{

    public partial class Form1 : Form
    {
        int t;
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t != 0)
            {
                controller.AddAsync(textBox1.Text);
                MessageBox.Show("Добавленно");
            }
            else
            {
                MessageBox.Show("Поле не должно быть бустым");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                t = 1;
                label2.Visible = false;
            }
            else
            {
                t = 0;
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(DataBase.GetAnsver(textBox1.Text));
        }
    }

}
