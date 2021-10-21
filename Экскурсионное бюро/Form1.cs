using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Экскурсионное_бюро;

namespace Экскурсионное_бюро
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            РаботаСЗаказами rz = new РаботаСЗаказами();
            rz.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ИнформацияПоСтрудникам infS = new ИнформацияПоСтрудникам();
            infS.Show();
            this.Hide();
        }
    }
}
