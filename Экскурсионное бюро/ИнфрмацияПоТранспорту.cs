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
    public partial class ИнфрмацияПоТранспорту : Form
    {
        public ИнфрмацияПоТранспорту()
        {
            InitializeComponent();
        }

        private void ИнфрмацияПоТранспорту_Load(object sender, EventArgs e)
        {
            транспортBindingSource.DataSource = db.Транспорт.ToList();
        }
        Model1 db = new Model1();

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        public string deletingId;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deletingId = транспортDataGridView.CurrentRow.Cells[0].Value.ToString();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            РедактированиеТранспорта rt = new РедактированиеТранспорта();
            rt.db = db;
            Транспорт транспорт = (Транспорт)транспортBindingSource.Current;
            rt.транспорт = транспорт;
            DialogResult dr = rt.ShowDialog();
            if (dr == DialogResult.OK)
            {
               транспортBindingSource.DataSource = db.Транспорт.ToList();
            }

        }
    }
}
