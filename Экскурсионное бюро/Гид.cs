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
    public partial class Гид : Form
    {
        public Гид()
        {
            InitializeComponent();
        }

        private void Гид_Load(object sender, EventArgs e)
        {
            гидыBindingSource.DataSource = db.Гиды.ToList();
        }
        Model1 db = new Model1();
        public string deletingId;
        private void button2_Click(object sender, EventArgs e)
        {
            deletingId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var r = from d in db.Гиды
                    where d.IDГида.ToString() == deletingId
                    select d;
            Гиды obj = r.SingleOrDefault();
            try
            {
                db.Гиды.Remove(obj);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                гидыBindingSource.DataSource = db.Гиды.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ИнформацияПоСтрудникам infS = new ИнформацияПоСтрудникам();
            infS.Show();
            this.Hide();
        }
    }
}
