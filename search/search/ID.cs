using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_search;
using DTO_search;

namespace search
{
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS bus = new BUS();
            if (textBox1.TextLength != 0)
            {
                dataGridView1.DataSource = bus.searchProductID(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                MessageBox.Show("No product ID is enterded!!");
            }
        }
    }
}
