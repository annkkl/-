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
    public partial class ИнформацияПоСтрудникам : Form
    {
        public ИнформацияПоСтрудникам()
        {
            InitializeComponent();
        }

        private void ИнформацияПоСтрудникам_Load(object sender, EventArgs e)
        {

        }

        private void managers_Click(object sender, EventArgs e)
        {
            Менеджер manager = new Менеджер();
            manager.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
           Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void guides_Click(object sender, EventArgs e)
        {
            Гид guide = new Гид();
            guide.Show();
            this.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Водитель driver = new Водитель();
            driver.Show();
            this.Hide();
        }
    }
}
