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
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }
        private void Менеджер_Load(object sender, EventArgs e)
        {
            менеджерыBindingSource.DataSource = db.Менеджеры.ToList();
        }

        private void ExitM_Click(object sender, EventArgs e)
        {
            ИнформацияПоСтрудникам infS = new ИнформацияПоСтрудникам();
            infS.Show();
            this.Hide();
        }
        Model1 db = new Model1();
        public string deletingId;

        private void DeleteM_Click(object sender, EventArgs e)
        {
            deletingId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Менеджеры
                    where d.IDМенеджера.ToString() == deletingId
                    select d;
            Менеджеры obj = r.SingleOrDefault();
            try
            {
                db.Менеджеры.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                менеджерыBindingSource.DataSource = db.Менеджеры.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void EditM_Click(object sender, EventArgs e)
        {

        }
    }
}
