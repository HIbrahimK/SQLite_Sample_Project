using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; //Projemize SQLite Data Adaptorunu kullanacağımızı belirtiyoruz.
using SQLiteProject;


namespace SQLiteProject
{
    public partial class SQLiteSampleProjects : Form
    {
        public SQLiteSampleProjects()
        {
            InitializeComponent();
        }

       

        private void jn7_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Link Zİyaret Edilince Yapılması Gereken Bir Olay Varsa Buradan Anlaşılabilir.
            // Specify that the link was visited. 
            jn7_lbl.LinkVisited = true;
            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.jn7.net");
        

        }

        private void createTable_btn_Click(object sender, EventArgs e)
        {
            SqLiteSampleProject.createTable();
            DataSet ds = new DataSet();
            ds =SqLiteSampleProject.dgFill();
            dGrid.DataSource= ds.Tables[0];
        }

        private void dropTable_btn_Click(object sender, EventArgs e)
        {
            SqLiteSampleProject.dropTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //Data Grid View Fill With Our Table Data
            DataSet ds = new DataSet();
            ds = SqLiteSampleProject.dgFill();
            dGrid.DataSource = ds.Tables[0];
        }

       
    }
}
