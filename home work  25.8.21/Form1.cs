using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work__25._8._21
{
    public partial class Form1 : Form
    {
        ClassCombine<int> cc = new ClassCombine<int>();
        ReadOnlyGenerics<string> Rg = new ReadOnlyGenerics<string>();
        item<int> item1 = new item<int>();
        item<double> item2 = new item<double>();
        item<char> item3 = new item<char>();
        General<student> Gstudent = new General<student>();
        General<Course> GCourse = new General<Course>();
        student stu = new student();
        Course cu = new Course();
        NameClass nc = new NameClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = cc.Combine(new int[int.Parse(textBox1.Text)], new int[int.Parse(textBox2.Text)]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rg.Add(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rg.ChangeReadOnly();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = item1.add(int.Parse(textBox6.Text)); 

            }
            catch 
            {
                try
                {
                     textBox5.Text = item2.add(double.Parse(textBox6.Text));
                }
                catch 
                {

                    try
                    {
                        textBox5.Text = item3.add(char.Parse(textBox6.Text));
                    }
                    catch 
                    {

                        textBox5.Text = "Error";
                    }
                }
                
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == stu.ToString()) 
            {
                textBox8.Text = Gstudent.Add(new student());
            }
            else if (textBox7.Text == cu.ToString() )
            {
                textBox8.Text = GCourse.Add(new Course());
            }
            else
            {
                textBox7.Text = "enter your choice here  ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Text = nc.PrintName();
            textBox10.Text = nc.ToString();               
        }
    }
}
