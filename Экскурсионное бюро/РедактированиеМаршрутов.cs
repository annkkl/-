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
    public partial class РедактированиеМаршрутов : Form
    {
        public РедактированиеМаршрутов()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Маршруты маршруты { get; set; }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            маршруты.IDВодителя = int.Parse(iDВодителяTextBox.Text);
            маршруты.IDГида = int.Parse(iDГидаTextBox.Text);
            маршруты.НазваниеМаршрута = названиеМаршрутаTextBox.Text;
            маршруты.НомерАвтобуса = номерАвтобусаTextBox.Text;
            маршруты.ПланПоездки = планПоездкиTextBox.Text;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void РедактированиеМаршрутов_Load(object sender, EventArgs e)
        {
            iDВодителяTextBox.Text = маршруты.IDВодителя.ToString();
            iDГидаTextBox.Text = маршруты.IDГида.ToString();
            названиеМаршрутаTextBox.Text = маршруты.НазваниеМаршрута;
            номерАвтобусаTextBox.Text = маршруты.НомерАвтобуса;
            планПоездкиTextBox.Text = маршруты.ПланПоездки;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
