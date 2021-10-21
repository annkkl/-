using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экскурсионное_бюро
{
    public partial class РаботаСЗаказами : Form
    {
        public РаботаСЗаказами()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ПросмотрЗаказов pz = new ПросмотрЗаказов();
            pz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            СозданиеЗаказов pz = new СозданиеЗаказов();
            pz.Show();
            this.Hide();
        }

        private void ExitRZ_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
