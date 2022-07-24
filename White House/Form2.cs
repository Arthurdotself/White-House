using Couchbase.KeyValue;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace White_House
{
    public partial class Form2 : Form
    {
        public object Int { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        public void getNum()
        {

            label13.Text = (Properties.Settings.Default.numberOfContract).ToString();

        }
        public void saveNum()
        {
            Properties.Settings.Default.numberOfContract = Properties.Settings.Default.numberOfContract + 1;
            Properties.Settings.Default.Save();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getNum();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            string sellname = textBox1.Text;
            string buyname = textBox2.Text;
            string type = textBox3.Text;
            string area = textBox4.Text;
            string nummolak = textBox5.Text;
            string price = "$" +textBox6.Text;
            string date = textBox7.Text;
          //  string ballForseller = textBox8.Text;
            string ballForboth = "$" +textBox9.Text ;
            string nebarhood = textBox10.Text;
            string loyar = textBox11.Text;
            string Path = @"C:\Users\Arthur\Desktop\whiteHouse\New\sell.docx";

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

            foreach (ContentRange item in dc.Content.Find(@"data2").Reverse())
            {
                item.Replace(date);
            }

          //  foreach (ContentRange item in dc.Content.Find(@"ballForseller").Reverse())
            {
         //       item.Replace(ballForseller);
            }

            foreach (ContentRange item in dc.Content.Find(@"ballForboth").Reverse())
            {
                item.Replace(ballForboth);
            }

            foreach (ContentRange item in dc.Content.Find(@"name3").Reverse())
            {
                item.Replace(loyar);
            }

            foreach (ContentRange item in dc.Content.Find(@"name4").Reverse())
            {
                item.Replace(listBox1.Text);
            }

            foreach (ContentRange item in dc.Content.Find(@"data").Reverse())
            {
                item.Replace(now.ToString("yyyy/MM/d"));
            }
            getNum();
            foreach (ContentRange item in dc.Content.Find(@"num2").Reverse())
            {
                item.Replace(label13.Text);
            }
            saveNum();
            
            // Save our document into PDF format.
            string savePath = "Replaced.docx";
            dc.Save(savePath, new DocxSaveOptions());

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });
            ///////
            ///


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
