using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWindows
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Shippers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shippers shippers = new Shippers()
            {
                CompanyName = txtSirket.Text,
                Phone=txtTelefon.Text

            };
            db.Shippers.Add(shippers);
            db.SaveChanges();
            dataGridView1.DataSource = db.Shippers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtSirket.Text = row.Cells["CompanyName"].Value.ToString();
                txtTelefon.Text = row.Cells["Phone"].Value.ToString();
                label3.Text = row.Cells["ShipperId"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int shipperId = int.Parse(label3.Text);

            var shipper = db.Shippers.Where(p => p.ShipperID == shipperId).FirstOrDefault();

            if (shipper != null) 
            { 
                shipper.Phone=txtTelefon.Text;
                shipper.CompanyName=txtSirket.Text;
                db.Shippers.AddOrUpdate(shipper);
                db.SaveChanges();

                dataGridView1.DataSource =db.Shippers.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int shipperId = int.Parse(label3.Text);

            var shipper = db.Shippers.Where(p => p.ShipperID == shipperId).FirstOrDefault();

            if (shipper != null)
            {
               db.Shippers.Remove(shipper);
                db.SaveChanges();

                dataGridView1.DataSource = db.Shippers.ToList();
            }
        }
    }
}
