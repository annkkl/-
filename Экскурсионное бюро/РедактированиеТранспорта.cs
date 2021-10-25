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
    public partial class РедактированиеТранспорта : Form
    {
        public РедактированиеТранспорта()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Транспорт транспорт { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            транспорт.НомерАвтобуса = nomer.Text;
            транспорт.Марка = marka.Text;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void РедактированиеТранспорта_Load(object sender, EventArgs e)
        {
            nomer.Text = транспорт.НомерАвтобуса;
            marka.Text = транспорт.Марка;
        }
    }
}
