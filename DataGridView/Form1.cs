using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] {"1"," اديب مصلح محمد العواضي","773332112","السبل " ,"بطاقة", "221112221", "منزلي","323435345" ,"545454545" });
            dataGridView1.Rows.Add(new object[] { "2", " محمد خالد الكامل", "773323223", "السياني","جواز", "2211154545", "تجاري", "323435345", "545454545" });
            dataGridView1.Rows.Add(new object[] { "3", "محمد احمد محمد ملهي الخال", "773324436", "الدائري", "جواز", "3232122435", "تجاري", "54546464646", "45465465464" });
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            Add_Sub form = new Add_Sub();
            form.ShowDialog(); 
        }
    }
}
