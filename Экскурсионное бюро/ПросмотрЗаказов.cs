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
    public partial class ПросмотрЗаказов : Form
    {
        public ПросмотрЗаказов()
        {
            InitializeComponent();
        }
        private void ПросмотрЗаказов_Load(object sender, EventArgs e)
        {
            заказыBindingSource.DataSource = db.Заказы.ToList();
        }

        Model1 db = new Model1();
        public string deletingId;
        private void button3_Click(object sender, EventArgs e)
        {
            deletingId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Заказы
                    where d.ID_Заказа.ToString() == deletingId
                    select d;
            Заказы obj = r.SingleOrDefault();
            try
            {
                db.Заказы.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                заказыBindingSource.DataSource = db.Заказы.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            РаботаСЗаказами rz = new РаботаСЗаказами();
            rz.Show();
            this.Hide();
        }
    }
}
