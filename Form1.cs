using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uskorenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double _v0, _a0, _time, _x0, _x, _v;
        public void InitData()
        {
            _v0 = Convert.ToDouble(textBox1.Text);
            _a0 = Convert.ToDouble(textBox2.Text);
            _time = Convert.ToDouble(textBox3.Text);
            _x0 = Convert.ToDouble(textBox4.Text);
        }
        public void Calc()
        {
            _v = _v0 + _a0 * _time;
            _x = _x0 + _v0 * _time + (_a0 * _time * _time) / 2;
        }
        public void ShowResult()
        {
            textBox5.Text = Convert.ToString(_x);
            textBox6.Text = Convert.ToString(_v);
        }
        public void Drow()
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            gr.DrawLine(pen, 0, 200, 300, 200);
            gr.DrawLine(pen, 0, 200, 0, 0);
            if (radioButton1.Checked)
            {

            }
            if (radioButton2.Checked)
            {

            }
            if (radioButton3.Checked)
            {

            }
        }
        void button1_Click(object sender, EventArgs e)
        {
            InitData();
            Calc();
            ShowResult();
            Drow();
        }
    }
}
