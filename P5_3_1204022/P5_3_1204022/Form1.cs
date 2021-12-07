using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P5_3_1204022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void charTextBox1_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Regex regex = new Regex("^.*/.*$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(textBox2.Text))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox2, "Regex Tidak Sesuai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rbLK.Checked == true || rbPR.Checked == true) && numericTextBox1.Text != "" && charTextBox1.Text != "" && textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text != "" && numericTextBox2.Text != "")
            {
                if (kr2006.Checked == true)
                {
                    groupBox2.Enabled = false;
                    groupBox2.Enabled = true;
                    checkBox12.Enabled = false;
                    checkBox9.Enabled = false;
                }
                else if (kr2010.Checked == true)
                {
                    groupBox2.Enabled = false;
                    groupBox2.Enabled = true;
                    checkBox1.Enabled = false;
                    checkBox9.Enabled = false;
                }

                else if (kr2014.Checked == true)
                {
                    groupBox2.Enabled = false;
                    groupBox2.Enabled = true;
                    checkBox1.Enabled = false;
                    checkBox12.Enabled = false;
                }
            }
            Size = new Size(800, 580);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string kelas = " ";
                if (checkBox1.Checked) { kelas += checkBox1.Text; }
                if (checkBox2.Checked) { kelas += checkBox2.Text; }
                if (checkBox10.Checked) { kelas += checkBox10.Text; }
                if (checkBox11.Checked) { kelas += checkBox11.Text; }
                if (checkBox12.Checked) { kelas += checkBox12.Text; }
                if (checkBox3.Checked) { kelas += checkBox3.Text; }
                if (checkBox4.Checked) { kelas += checkBox4.Text; }
                if (checkBox5.Checked) { kelas += checkBox5.Text; }
                if (checkBox6.Checked) { kelas += checkBox6.Text; }
                if (checkBox7.Checked) { kelas += checkBox7.Text; }
                if (checkBox8.Checked) { kelas += checkBox8.Text; }
                if (checkBox9.Checked) { kelas += checkBox9.Text; }
                string labelJK = rbLK.Checked == true ? rbLK.Text : rbPR.Text;
                string kuri = "";
                if (kr2006.Checked) { kuri = kr2006.Text; } else if (kr2010.Checked) { kuri = kr2010.Text; } else if (kr2014.Checked) { kuri = kr2014.Text; }
                string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", numericTextBox1.Text, charTextBox1.Text, labelJK, textBox1.Text, comboBox1.Text, textBox2.Text, numericTextBox2.Text, kuri, kelas);
                MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
