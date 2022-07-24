using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft.Document;

namespace White_House
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void getNum()
        {

            textBox11.Text = (Properties.Settings.Default.numberOfContract).ToString();

        }
        public void saveNum()
        {
            Properties.Settings.Default.numberOfContract = Properties.Settings.Default.numberOfContract + 1;
            Properties.Settings.Default.Save();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getNum();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sellname = textBox1.Text;
            string buyname = textBox2.Text;
            string type = textBox3.Text;
            string area = textBox4.Text;
            string nebarhood = textBox5.Text;
            string nummolak = textBox6.Text;
            string price =  textBox7.Text;
            string tamenat = textBox8.Text;
            string payBeforDay = textBox9.Text;
            string activetime = listBox1.Text;
            string startfrom = textBox10.Text;
            string reantpayfor = comboBox2.Text;
            string mobile1 = textBox12.Text;
            string mobile2 = textBox13.Text;
            DateTime now = DateTime.Now;
            getNum();

            //  string loyar = textBox11.Text;
            string Path = @"C:\Users\Arthur\Desktop\whiteHouse\New\reant.docx";

            DocumentCore dc = DocumentCore.Load(Path);



            foreach (ContentRange item in dc.Content.Find(@"name1").Reverse())
            {
                item.Replace(sellname);
            }

            foreach (ContentRange item in dc.Content.Find(@"name2").Reverse())
            {
                item.Replace(buyname);
            }

            foreach (ContentRange item in dc.Content.Find(@"type").Reverse())
            {
                item.Replace(type);
            }

            foreach (ContentRange item in dc.Content.Find(@"num1").Reverse())
            {
                item.Replace(nummolak);
            }

            foreach (ContentRange item in dc.Content.Find(@"proja").Reverse())
            {
                item.Replace(nebarhood);
            }

            foreach (ContentRange item in dc.Content.Find(@"area").Reverse())
            {
                item.Replace(area);
            }

            foreach (ContentRange item in dc.Content.Find(@"price").Reverse())
            {
                item.Replace(price);
            }

            foreach (ContentRange item in dc.Content.Find(@"datefrom").Reverse())
            {
                item.Replace(startfrom);
            }

            foreach (ContentRange item in dc.Content.Find(@"reantpayfor").Reverse())
            {
                item.Replace(reantpayfor);
            }

            foreach (ContentRange item in dc.Content.Find(@"1to7").Reverse())
            {
                 item.Replace(payBeforDay);
            }

            foreach (ContentRange item in dc.Content.Find(@"tamenat").Reverse())
            {
                item.Replace(tamenat);
            }

            foreach (ContentRange item in dc.Content.Find(@"activetiontime").Reverse())
            {
                item.Replace(activetime);
            }

            foreach (ContentRange item in dc.Content.Find(@"name3").Reverse())
            {
                item.Replace(listBox2.Text);
            }

            foreach (ContentRange item in dc.Content.Find(@"data").Reverse())
            {
                item.Replace(now.ToString("yyyy/M/d"));
            }

            foreach (ContentRange item in dc.Content.Find(@"num").Reverse())
            {
                item.Replace(textBox11.Text);
            }

            foreach (ContentRange item in dc.Content.Find(@"num01").Reverse())
            {
                item.Replace(mobile1);
            }

            foreach (ContentRange item in dc.Content.Find(@"num02").Reverse())
            {
                item.Replace(mobile2);
            }
            
            string savePath = "Replaced.docx";
            dc.Save(savePath, new DocxSaveOptions());

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });
            saveNum();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
