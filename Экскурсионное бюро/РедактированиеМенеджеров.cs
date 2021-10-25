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
    public partial class РедактированиеМенеджеров : Form
    {
        public РедактированиеМенеджеров()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Менеджеры менеджеры { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            менеджеры.ФИО = фИОTextBox.Text;
            менеджеры.НомерТелефона = номерТелефонаTextBox.Text;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void РедактированиеМенеджеров_Load(object sender, EventArgs e)
        {
            фИОTextBox.Text = менеджеры.ФИО;
            номерТелефонаTextBox.Text = менеджеры.НомерТелефона;
        }
    }
}
