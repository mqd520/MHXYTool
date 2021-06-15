using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHXYTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cz = 0;
            bool b = double.TryParse(textBox1.Text.Trim(), out cz);
            if (!b)
            {
                MessageBox.Show("请输入正确格式的成长!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            double level = Convert.ToDouble(numericUpDown1.Value);
            double gjzz = Convert.ToDouble(numericUpDown2.Value);
            double ll = Convert.ToDouble(numericUpDown3.Value);
            double tlzz = Convert.ToDouble(numericUpDown4.Value);
            double tz = Convert.ToDouble(numericUpDown5.Value);
            double fyzz = Convert.ToDouble(numericUpDown6.Value);
            double nl = Convert.ToDouble(numericUpDown7.Value);
            double sdzz = Convert.ToDouble(numericUpDown8.Value);
            double mj = Convert.ToDouble(numericUpDown9.Value);

            double gj = (level * gjzz * (14 + 10 * cz) / 7500) + (cz * ll);
            label6.Text = gj.ToString();
            double qx = (level * tlzz / 1000) + (cz * tz * 6);
            label8.Text = qx.ToString();
            double fy = (level * fyzz * (9.4 + (19 / 3) * cz) / 7500) + (cz * nl * 4 / 3);
            label12.Text = fy.ToString();
            double sd = sdzz * mj / 1000;
            label16.Text = sd.ToString();
        }
    }
}
