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
    public partial class ИнформацияПоТранспорту : Form
    {
        public ИнформацияПоТранспорту()
        {
            InitializeComponent();
        }

        private void ИнформацияПоТранспорту_Load(object sender, EventArgs e)
        {
            транспортBindingSource.DataSource = db.Транспорт.ToList();
        }
        Model1 db = new Model1();

        private void ExitT_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        public string deletingId;
        private void DeleteT_Click(object sender, EventArgs e)
        {
            deletingId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Транспорт
                    where d.НомерАвтобуса.ToString() == deletingId
                    select d;
            Транспорт obj = r.SingleOrDefault();
            try
            {
                db.Транспорт.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                транспортBindingSource.DataSource = db.Транспорт.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditT_Click(object sender, EventArgs e)
        {

        }
    }
}
