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
    public partial class РедактированиеЗаказов : Form
    {
        public РедактированиеЗаказов()
        {
            InitializeComponent();
        }
        public Model1 db { get; set; }
        public Заказы заказы { get; set; }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            заказы.IDМенеджера = iDМенеджераComboBox.SelectedIndex;
            заказы.ДатаПоездки = датаПоездкиDateTimePicker.Value;
            заказы.КодМаршрута = кодМаршрутаComboBox.SelectedIndex;
            //заказы.Стоимость = стоимостьTextBox.Text;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void РедактированиеЗаказов_Load(object sender, EventArgs e)
        {
            iDМенеджераComboBox.SelectedIndex = заказы.IDМенеджера;
            датаПоездкиDateTimePicker.Value = заказы.ДатаПоездки;
            кодМаршрутаComboBox.SelectedIndex = заказы.КодМаршрута;
            //стоимостьTextBox.Text = заказы.Стоимость;
        }
    }
}
