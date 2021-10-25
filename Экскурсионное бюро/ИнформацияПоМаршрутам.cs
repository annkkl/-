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
    public partial class ИнформацияПоМаршрутам : Form
    {
        public ИнформацияПоМаршрутам()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        private void ИнформацияПоМаршрутам_Load(object sender, EventArgs e)
        {
            маршрутыBindingSource.DataSource = db.Маршруты.ToList();
        }

        Model1 db = new Model1();
        public string deletingId;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deletingId = маршрутыDataGridView.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Маршруты
                    where d.IDМаршрута.ToString() == deletingId
                    select d;
            Маршруты obj = r.SingleOrDefault();
            try
            {
                db.Маршруты.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                маршрутыBindingSource.DataSource = db.Маршруты.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            РедактированиеМаршрутов rm = new РедактированиеМаршрутов();
            rm.db = db;
            Маршруты маршруты = (Маршруты)маршрутыBindingSource.Current;
            rm.маршруты = маршруты;
            DialogResult dr = rm.ShowDialog();
            if (dr == DialogResult.OK)
            {
               маршрутыBindingSource.DataSource = db.Маршруты.ToList();
            }
        }
    }
}
