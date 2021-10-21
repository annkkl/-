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
    public partial class Водитель : Form
    {
        public Водитель()
        {
            InitializeComponent();
        }

        private void Водитель_Load(object sender, EventArgs e)
        {
            водителиBindingSource.DataSource = db.Водители.ToList();
        }
        Model1 db = new Model1();

        private void button3_Click(object sender, EventArgs e)
        {
            ИнформацияПоСтрудникам infS = new ИнформацияПоСтрудникам();
            infS.Show();
            this.Hide();
        }

        public string deletingId;
        private void DeleteDr_Click(object sender, EventArgs e)
        {
            deletingId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Водители
                    where d.IDВодителя.ToString() == deletingId
                    select d;
            Водители obj = r.SingleOrDefault();
            try
            {
                db.Водители.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                водителиBindingSource.DataSource = db.Водители.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
