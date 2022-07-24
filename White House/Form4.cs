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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            string therd = textBox3.Text;
            string forth = textBox4.Text;
            DateTime Now  = DateTime.Now;

            string Path = @"C:\Users\Arthur\Desktop\whiteHouse\New\pay.docx";

            DocumentCore dc = DocumentCore.Load(Path);



            foreach (ContentRange item in dc.Content.Find(@"first").Reverse())
            {
                item.Replace(name1);
            }

            foreach (ContentRange item in dc.Content.Find(@"sec").Reverse())
            {
                item.Replace(name2);
            }

            foreach (ContentRange item in dc.Content.Find(@"therd").Reverse())
            {
                item.Replace(therd);
            }

            foreach (ContentRange item in dc.Content.Find(@"forth").Reverse())
            {
                item.Replace(forth);
            }

            foreach (ContentRange item in dc.Content.Find(@"date").Reverse())
            {
                item.Replace(Now.ToString("yyyy/M/d"));
            }
            string savePath = "Relaced.docx";
            dc.Save(savePath, new DocxSaveOptions());

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savePath) { UseShellExecute = true });
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
