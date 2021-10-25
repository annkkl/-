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
    public partial class РедактированиеВодителей : Form
    {
        public РедактированиеВодителей()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Водители водители { get; set; }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            водители.ФИО = фИОTextBox.Text;
            водители.Возраст = int.Parse(возрастTextBox.Text);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
        private void РедактированиеВодителей_Load(object sender, EventArgs e)
        {
            фИОTextBox.Text = водители.ФИО;
            возрастTextBox.Text = водители.Возраст.ToString();
        }

    }
}
