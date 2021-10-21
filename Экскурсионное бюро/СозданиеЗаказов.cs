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
    public partial class СозданиеЗаказов : Form
    {
        public СозданиеЗаказов()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void СозданиеЗаказов_Load(object sender, EventArgs e)
        {
            //кодМаршрутаComboBox.DataSource = ds.Tables[0];
            //кодМаршрутаComboBox.DisplayMember = "НазваниеМаршрута";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void кодМаршрутаComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void кодМаршрутаLabel_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
