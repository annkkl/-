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
    public partial class РедактированиеГидов : Form
    {
        public РедактированиеГидов()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Гиды гиды { get; set; }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            гиды.ФИО = фИОTextBox.Text;
            гиды.Возраст = int.Parse(возрастTextBox.Text);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void РедактированиеГидов_Load(object sender, EventArgs e)
        {
            фИОTextBox.Text = гиды.ФИО;
            возрастTextBox.Text = гиды.Возраст.ToString();
        }
    }
}
